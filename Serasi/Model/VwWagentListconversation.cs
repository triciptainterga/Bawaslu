using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class VwWagentListconversation
    {
        public string WaAccount { get; set; }
        public long Id { get; set; }
        public long WaMWhatsappAccountId { get; set; }
        public string Nomor { get; set; }
        public string Wid { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public long? ConversationId { get; set; }
        public string StatusWa { get; set; }
        public string ASenderName { get; set; }
        public string SenderName { get; set; }
    }
}
