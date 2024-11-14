using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class GetWebhukMultichat
    {
        public int Id { get; set; }
        public string EmailHuk { get; set; }
        public string TxtGetWebhuk { get; set; }
        public DateTime? DateGetData { get; set; }
        public string PageId { get; set; }
        public string SourceSocmed { get; set; }
        public string SourceItem { get; set; }
        public string MessageSocmed { get; set; }
        public string PostId { get; set; }
        public string ParentId { get; set; }
        public string CommentId { get; set; }
        public string PermalinkUrl { get; set; }
        public string FromId { get; set; }
        public string FromName { get; set; }
        public string IsHidden { get; set; }
        public string VerbData { get; set; }
    }
}
