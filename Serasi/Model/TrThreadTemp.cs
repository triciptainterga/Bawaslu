using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class TrThreadTemp
    {
        public int Id { get; set; }
        public string ValueThread { get; set; }
        public string GenesysNumber { get; set; }
        public string ThreadId { get; set; }
        public string Account { get; set; }
        public string AccountContactId { get; set; }
        public string AgentId { get; set; }
        public string Subject { get; set; }
        public string TicketNumber { get; set; }
        public string Type { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DatePickup { get; set; }
        public string CustomerId { get; set; }
        public string PhoneChat { get; set; }
        public string ThreadCustomerName { get; set; }
        public string ThreadChannelDetail { get; set; }
        public string AgentGroup { get; set; }
        public string SiteId { get; set; }
        public string WhatsAppNumber { get; set; }
    }
}
