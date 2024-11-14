using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class IccHistorySla
    {
        public int Id { get; set; }
        public string TicketNumber { get; set; }
        public string Slasebelumnya { get; set; }
        public string Slasesudahnya { get; set; }
        public string Description { get; set; }
        public string Usercreate { get; set; }
        public DateTime? Datecreate { get; set; }
    }
}
