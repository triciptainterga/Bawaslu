using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class DatakelolaVChatbody
    {
        public decimal? Id { get; set; }
        public decimal ChatHeaderId { get; set; }
        public decimal SenderId { get; set; }
        public string SenderType { get; set; }
        public decimal? UserHandleId { get; set; }
        public string Message { get; set; }
        public decimal HasAttachment { get; set; }
        public string Attachment { get; set; }
        public string AttachmentInfo { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string MessageId { get; set; }
        public decimal HasSeen { get; set; }
        public int ReplyTimeLapsed { get; set; }
        public decimal HasMigrate { get; set; }
    }
}
