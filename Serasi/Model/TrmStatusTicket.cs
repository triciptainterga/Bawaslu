using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class TrmStatusTicket
    {
        public string StatusData { get; set; }
        public int Id { get; set; }
        public string Status { get; set; }
        public string LblStatus { get; set; }
        public int? Urutan { get; set; }
        public string Na { get; set; }
        public string UserCreate { get; set; }
        public DateTime? DateCreate { get; set; }
        public string Reminder { get; set; }
        public string Color { get; set; }
        public string Icon { get; set; }
    }
}
