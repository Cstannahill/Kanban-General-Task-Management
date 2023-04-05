using Models.Domain.Appointments;
using Sabio.Models.Requests.Appointments;
using System.Collections.Generic;

namespace Sabio.Services.Interfaces
{
    public interface IAppointmentService
    {
        public int AddAppointment(AppointmentAddRequest model);

        public List<Appointment> GetAppointmentsByWeek();
    }
}