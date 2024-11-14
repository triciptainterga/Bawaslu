using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class TempRSurveyCsat
    {
        public string Username { get; set; }
        public string UniqueId { get; set; }
        public string TicketNumber { get; set; }
        public string Channel { get; set; }
        public string ResultCsat { get; set; }
        public DateTime? DateCsat { get; set; }
        public DateTime? DateCreate { get; set; }
        public string ValueDetailX { get; set; }
        public string ValueDetail { get; set; }
    }
}
