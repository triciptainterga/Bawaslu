using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class TUideskMultichatHistory
    {
        public string Username { get; set; }
        public string Agentname { get; set; }
        public string CompanyId { get; set; }
        public string Code { get; set; }
        public string AccountName { get; set; }
        public string Status { get; set; }
        public string HandleBy { get; set; }
        public string Id { get; set; }
        public string ChatHeaderId { get; set; }
        public string SenderId { get; set; }
        public string SenderType { get; set; }
        public string UserHandleId { get; set; }
        public string Message { get; set; }
        public string HasAttachment { get; set; }
        public string Attachment { get; set; }
        public string AttachmentInfo { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
        public string MessageId { get; set; }
        public string HasSeen { get; set; }
        public string ReplyTimeLapsed { get; set; }
        public string JamCreate { get; set; }
        public string Usercreate { get; set; }
    }
}
