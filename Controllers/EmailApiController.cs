using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sabio.Services;
using Sabio.Web.Controllers;
using Sabio.Web.Models.Responses;
using System;
using Sabio.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Sabio.Models.Requests;

namespace Sabio.Web.Api.Controllers
{
    [Route("api/emails")]
    [ApiController]
    public class EmailApiController : BaseApiController
    {
        private IEmailService _service = null;
        private IAuthenticationService<int> _authService = null;

        public EmailApiController(IEmailService service,
            ILogger<EmailApiController> logger,
            IAuthenticationService<int> authService) : base(logger)
        {
            _service = service;
            _authService = authService;
        }

        [HttpPost("welcome")]
        public ActionResult<SuccessResponse> Create(EmailRequest emailRequest)
        {
            int code = 200;
            BaseResponse response = null;
            try
            {
                _service.SendWelcome(emailRequest);
                response = new SuccessResponse();
            }
            catch (Exception ex)
            {
                code = 500;
                response = new ErrorResponse(ex.Message);
                Logger.LogError(ex.ToString());
            }
            return StatusCode(code, response);
        }

        [HttpPost("contactus")]
        [AllowAnonymous]
        public ActionResult<SuccessResponse> ContactUs(ContactUsRequest contactRequest)
        {
            int code = 200;
            BaseResponse response = null;
            try
            {
                _service.SendContactUsEmail(contactRequest);
                response = new SuccessResponse();
            }
            catch (Exception ex)
            {
                code = 500;
                response = new ErrorResponse(ex.Message);
                Logger.LogError(ex.ToString());
            }
            return StatusCode(code, response);
        }
        [HttpPut("forgotpassword/{token}")]
        [AllowAnonymous]
        public ActionResult<SuccessResponse> ForgotPassword(string email, string token)
        {
            int code = 200;

            BaseResponse response = null;
            try
            {
                _service.ForgotPassword(email, token);
                response = new SuccessResponse();
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

