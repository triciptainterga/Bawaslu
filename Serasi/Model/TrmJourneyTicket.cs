using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class TrmJourneyTicket
    {
        public string LevelUser { get; set; }
        public string ValueThread { get; set; }
        public string Account { get; set; }
        public string DateThread { get; set; }
        public string ThreadDescription { get; set; }
        public string TicketNumber { get; set; }
        public string ThreadId { get; set; }
        public string GenesysNumber { get; set; }
        public string DetailComplaint { get; set; }
        public string ResponseComplaint { get; set; }
        public string AgentCreate { get; set; }
        public string DateCreate { get; set; }
        public int? InteractionId { get; set; }
    }
}
