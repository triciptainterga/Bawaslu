using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class TrThreadArchive
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
        public string ThreadReason { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DatePickup { get; set; }
        public string UserUpdate { get; set; }
        public DateTime? DateUpdate { get; set; }
        public string CustomerId { get; set; }
        public string PhoneChat { get; set; }
        public string ThreadProblem { get; set; }
        public string ThreadDescription { get; set; }
        public string ThreadDepartment { get; set; }
        public string ThreadPriority { get; set; }
        public string ThreadCustomerName { get; set; }
        public string ThreadAsset { get; set; }
        public string ThreadAssetId { get; set; }
        public string ThreadProblemId { get; set; }
        public string ThreadCategoryId { get; set; }
        public string ThreadCategory { get; set; }
        public string ThreadDepartmentId { get; set; }
        public DateTime? DateTransaction { get; set; }
        public string ThreadChannelDetail { get; set; }
        public string TableThreadId { get; set; }
        public string TableNumberId { get; set; }
        public string FlagingEmailReply { get; set; }
        public string AgentGroup { get; set; }
        public string SiteId { get; set; }
        public string WhatsAppNumber { get; set; }
        public DateTime? DateSolving { get; set; }
    }
}
