using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class VwRSlaNew
    {
        public string TicketSourceName { get; set; }
        public string TicketNumber { get; set; }
        public string Status { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateClose { get; set; }
        public DateTime? DateSolved { get; set; }
        public int Sla { get; set; }
        public int? OverSlanya { get; set; }
        public string StatusSla { get; set; }
    }
}
