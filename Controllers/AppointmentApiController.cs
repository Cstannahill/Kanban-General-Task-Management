using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Models.Domain.Appointments;
using Sabio.Models.Requests.Appointments;
using Sabio.Services.Interfaces;
using Sabio.Web.Models.Responses;
using System;
using System.Collections.Generic;

namespace Sabio.Web.Api.Controllers
{
    [Route("api/appointments")]
    [ApiController]
    public class AppointmentApiController : ControllerBase
    {
        private IAuthenticationService _authService = null;
        private IAppointmentService _service = null;

        public AppointmentApiController(IAppointmentService service, IAuthenticationService authService)
        {
            _authService = authService;
            _service = service;
        }

        [HttpGet]
        public ActionResult<ItemsResponse<Appointment>> GetAllApplications(int id)
        {
            int code = 200;
            BaseResponse response = null;
            List<Appointment> appointments = null;

            try
            {
                appointments = _service.GetAppointmentsByWeek();

                if (appointments == null)
                {
                    code = 404;
                    response = new ErrorResponse("App Resource not found.");
                }
                else
                {
                    response = new ItemsResponse<Appointment> { Items = appointments };
                }
            }
            catch (Exception ex)
            {
                code = 500;
                response = new ErrorResponse(ex.Message);
            }
            return StatusCode(code, response);
        }

        [HttpPost]
        public ActionResult<ItemResponse<int>> Create(AppointmentAddRequest model)
        {
            int code = 201;
            BaseResponse response = null;

            try
            {
                int id = _service.AddAppointment(model);
                response = new ItemResponse<int> { Item = id };
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