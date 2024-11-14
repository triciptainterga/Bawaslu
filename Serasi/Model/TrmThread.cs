using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class TrmThread
    {
        public string ValueThread { get; set; }
        public string ThreadId { get; set; }
        public string GenesysNumber { get; set; }
        public string Account { get; set; }
        public string AgentId { get; set; }
        public string TicketNumber { get; set; }
        public string CustomerId { get; set; }
        public string PhoneChat { get; set; }
        public string ThreadCustomerName { get; set; }
        public DateTime? DateCreate { get; set; }
        public string ThreadDescription { get; set; }
    }
}
