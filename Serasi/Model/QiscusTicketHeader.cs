using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class QiscusTicketHeader
    {
        public long Id { get; set; }
        public string IdChannel { get; set; }
        public string IdRoom { get; set; }
        public long AgentId { get; set; }
        public long CustomerId { get; set; }
        public string ChannelId { get; set; }
        public string ChannelName { get; set; }
        public string ChannelType { get; set; }
        public string Notes { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
