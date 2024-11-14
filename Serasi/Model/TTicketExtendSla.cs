using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class TTicketExtendSla
    {
        public int Id { get; set; }
        public string Idextend { get; set; }
        public int? Sla { get; set; }
        public string TicketNumber { get; set; }
        public string UserCreate { get; set; }
        public DateTime? DateCreate { get; set; }
    }
}
