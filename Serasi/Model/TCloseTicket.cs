using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class TCloseTicket
    {
        public int Id { get; set; }
        public string TicketNumber { get; set; }
        public DateTime? DateClose { get; set; }
        public string Sla { get; set; }
        public string Na { get; set; }
        public DateTime? DateCloseActual { get; set; }
        public DateTime? DateCloseAuto { get; set; }
        public string StatusTicket { get; set; }
    }
}
