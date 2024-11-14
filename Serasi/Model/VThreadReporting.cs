using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class VThreadReporting
    {
        public string TypeData { get; set; }
        public DateTime? DateInbox { get; set; }
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
        public string ThreadReason { get; set; }
        public DateTime? DateCreate { get; set; }
        public string UserUpdate { get; set; }
        public DateTime? DateUpdate { get; set; }
        public string CustomerId { get; set; }
        public string PhoneChat { get; set; }
        public string Name { get; set; }
        public string Cif { get; set; }
        public string AgentGroup { get; set; }
        public string AgentGroupName { get; set; }
        public string SiteName { get; set; }
        public string WhatsAppNumber { get; set; }
    }
}
