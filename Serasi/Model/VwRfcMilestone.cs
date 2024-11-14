using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class VwRfcMilestone
    {
        public string TicketNumber { get; set; }
        public string InteractionType { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateResponse { get; set; }
        public int? DispatchTo { get; set; }
    }
}
