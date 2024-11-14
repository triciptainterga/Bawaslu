using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class VwJourneyTicket
    {
        public string TicketNumber { get; set; }
        public string HeaderSosmed { get; set; }
        public string ProfileName { get; set; }
        public string FlagTo { get; set; }
        public long? ProfileId { get; set; }
        public string BodyData { get; set; }
        public DateTime? DateGetSosmed { get; set; }
        public DateTime? DateCreate { get; set; }
        public string StatusType { get; set; }
        public string DateNya { get; set; }
    }
}
