using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class SocialMediaAttachAll
    {
        public int Id { get; set; }
        public string SocialMediaChatId { get; set; }
        public string FileType { get; set; }
        public string FileUrl { get; set; }
        public string SourceChat { get; set; }
        public string Active { get; set; }
        public DateTime? DateCreate { get; set; }
    }
}
