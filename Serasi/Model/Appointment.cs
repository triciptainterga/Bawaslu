using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class Appointment
    {
        public decimal Id { get; set; }
        public string Username { get; set; }
        public decimal? Idcalllist { get; set; }
        public int? Status { get; set; }
        public int? Notif { get; set; }
        public DateTime? Dated { get; set; }
        public string NoAppointment { get; set; }
        public string Capaign { get; set; }
    }
}
