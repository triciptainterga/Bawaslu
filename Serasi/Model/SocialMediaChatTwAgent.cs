using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class SocialMediaChatTwAgent
    {
        public int Id { get; set; }
        public string ChatId { get; set; }
        public string AgentId { get; set; }
        public DateTime? DateGet { get; set; }
    }
}
