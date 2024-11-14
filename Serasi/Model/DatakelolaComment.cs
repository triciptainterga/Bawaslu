using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class DatakelolaComment
    {
        public string Jenis { get; set; }
        public string CommentId { get; set; }
        public string PostId { get; set; }
        public string ProfileId { get; set; }
        public string Messages { get; set; }
        public string SourceSocmed { get; set; }
        public string StatusType { get; set; }
        public string GettimeSocmedAt { get; set; }
        public string IsActive { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public decimal? CanPrivateReply { get; set; }
    }
}
