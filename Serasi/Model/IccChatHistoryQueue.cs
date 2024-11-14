using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class IccChatHistoryQueue
    {
        public decimal IvcId { get; set; }
        public string Channeltype { get; set; }
        public DateTime? Dated { get; set; }
        public string CustomerId { get; set; }
        public string CompId { get; set; }
        public string GroupId { get; set; }
        public string OrganizationId { get; set; }
    }
}
