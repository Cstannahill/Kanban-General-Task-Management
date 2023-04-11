using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using Models.Domain;
using Models.Domain.Users;
using Sabio.Models.Enums;
using Sabio.Models.Requests.Users;
using Sabio.Services;
using Sabio.Services.Interfaces;
using Sabio.Web.Controllers;
using Sabio.Web.Models.Responses;
using System;
using System.Reflection;
using System.Threading.Tasks;

namespace Sabio.Web.Api.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersApiControllerV1 : ControllerBase
    {
        private IEmailService _emailService = null;
        private IUserService _service = null;
        private IAuthenticationService<int> _authService = null;

        public UsersApiControllerV1(IUserService service, IEmailService emailService,
            IAuthenticationService<int> authService)
        {
            _service = service;
            _authService = authService;
            _emailService = emailService;
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult<ItemResponse<int>> Create(UserAddRequest model)
        {
            ObjectResult result = null;
            try
            {
                int userId = _service.Create(model);
                if (userId > 0)
                {
                    string token = Guid.NewGuid().ToString();
                    int tokenType = (int)TokenType.NewUser;
                    _service.AddToken(token, userId, tokenType);
                    _emailService.Confirm(model.Email, token);
                }
                ItemResponse<int> response = new ItemResponse<int> { Item = userId };
                result = StatusCode(200, response);
            }
            catch (Exception ex)
            {
                ErrorResponse response = new ErrorResponse(ex.ToString());
                result = StatusCode(500, response);
            }
            return result;
        }

        [HttpPut("confirm/{token}")]
        [AllowAnonymous]
        public ActionResult<SuccessResponse> ConfirmUser(string token)
        {
            int code = 200;

            BaseResponse response = null;
            try
            {
                _service.ConfirmUser(token);
                response = new SuccessResponse();
            }
            catch (Exception ex)
            {
                code = 500;
                response = new ErrorResponse(ex.Message);
            }
            return StatusCode(code, response);
        }

        [HttpGet("logout")]
        public async Task<ActionResult<SuccessResponse>> LogOut()
        {
            int code = 200;
            BaseResponse response = null;
            try
            {
                await _authService.LogOutAsync();
                response = new SuccessResponse();
            }
            catch (Exception ex)
            {
                code = 500;
                response = new ErrorResponse(ex.Message);
            }
            return StatusCode(code, response);
        }

        [HttpGet("current")]
        public ActionResult<ItemResponse<User>> CurrentUser()
        {
            int code = 200;
            BaseResponse response = null;
            int userId = _authService.GetCurrentUserId();
            try
            {
                User aUser = _service.GetCurrent(userId);
                if (aUser == null)
                {
                    code = 404;
                    response = new ErrorResponse("User not found.");
                }
                else
                {
                    response = new ItemResponse<User>() { Item = aUser };
                }
            }
            catch (Exception ex)
            {
                code = 500;
                response = new ErrorResponse(ex.Message);
            }
            return StatusCode(code, response);
        }

        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<ActionResult<SuccessResponse>> Login(UserLogin model)
        {
            int code = 200;
            BaseResponse response = null;
            bool success = false;

            try
            {
                success = await _service.LogInAsync(model.Email, model.Password);
                if (success == false)
                {
                    code = 404;
                    response = new ErrorResponse("Login Error");
                }
                else
                {
                    response = new SuccessResponse();
                }
            }
            catch (Exception ex)
            {
                code = 500;
                response = new ErrorResponse(ex.Message);
            }
            return StatusCode(code, response);
        }

        
    }
}
