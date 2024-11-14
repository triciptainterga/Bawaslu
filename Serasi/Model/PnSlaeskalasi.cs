using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class PnSlaeskalasi
    {
        public int Id { get; set; }
        public string TicketNumber { get; set; }
        public int? InteractionId { get; set; }
        public string UserName { get; set; }
        public string LevelUser { get; set; }
        public DateTime? DateCreateTicket { get; set; }
        public DateTime? DateEskalasi { get; set; }
        public DateTime? DateCloseTicket { get; set; }
        public int? Sla { get; set; }
        public DateTime? DateCreate { get; set; }
    }
}
