using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Models.Domain.AppKeys;
using Sabio.Services;
using Sabio.Web.Controllers;
using Sabio.Web.Models.Responses;
using System;

namespace Sabio.Web.Api.Controllers
{
    /// <summary>
    /// This controller is not required for the application to work.
    /// You could remove it but it serves as a simple entry point for development
    /// </summary>
    [Route("api/ping")]
    [ApiController]
    public class PingApiController : BaseApiController
    {
        private AppKeys _appKeys;
        private IAuthenticationService<int> _authService = null;

        public PingApiController(IOptions<AppKeys> appKeys, ILogger<PingApiController> logger, IAuthenticationService<int> authService) : base(logger)
        {
            _authService = authService;
            _appKeys = appKeys.Value;
        }

        [HttpGet()]
        [AllowAnonymous]
        public ActionResult<ItemResponse<object>> Ping()
        {
            Logger.LogInformation("Ping endpoint firing");

            ItemResponse<object> response = new ItemResponse<object>();

            response.Item = new { Now = DateTime.Now.Ticks, Message = "If you are taking an assessment, you must not know you graduated already: https://localhost:50001/api/temp/auth/login/1008/developer/code-small-role" };

            return Ok200(response);
        }
    }
}