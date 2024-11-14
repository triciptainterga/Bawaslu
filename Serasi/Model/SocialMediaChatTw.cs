using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class SocialMediaChatTw
    {
        public int Id { get; set; }
        public string ChatId { get; set; }
        public string ChatType { get; set; }
        public string DateGetdm { get; set; }
        public string RecipientId { get; set; }
        public string SenderId { get; set; }
        public string SourceAppIdDm { get; set; }
        public string Messages { get; set; }
        public string AppsId { get; set; }
        public string AppsName { get; set; }
        public string SenderName { get; set; }
        public string SenderLocation { get; set; }
        public string ReceiveName { get; set; }
        public string ReceiveLocation { get; set; }
        public DateTime? DateCreate { get; set; }
        public string CustomerPicUrl { get; set; }
        public string Active { get; set; }
        public string SosmedAgent { get; set; }
        public DateTime? SosmedDistributionDate { get; set; }
        public string SessionConvId { get; set; }
    }
}
