using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class VwAutoClosedRfcStatusDoc
    {
        public long? RowNum { get; set; }
        public string CategoryId { get; set; }
        public string TicketNumber { get; set; }
        public string TicketSourceName { get; set; }
        public string CategoryName { get; set; }
        public DateTime? DateCreate { get; set; }
        public int? Sla20 { get; set; }
        public int? Sla10 { get; set; }
        public DateTime? LastDatInteraction { get; set; }
        public string JenisParam { get; set; }
        public int? IntervalDate { get; set; }
        public string EksekusiAutoClosed { get; set; }
    }
}
