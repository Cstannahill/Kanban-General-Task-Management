using System;

namespace Sabio.Models.Requests.Appointments
{
    public class AppointmentAddRequest
    {
        public string Company { get; set; }
        public DateTime Date { get; set; }
        public string ContactName { get; set; }
        public string ContactMethod { get; set; }
    }
}