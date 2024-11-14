using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class SocialMediaLike
    {
        public int Id { get; set; }
        public string PostId { get; set; }
        public string ParentId { get; set; }
        public string CommentId { get; set; }
        public string FlagTo { get; set; }
        public string ProfileId { get; set; }
        public string ProfileName { get; set; }
        public string ProfileEmail { get; set; }
        public string ReactionType { get; set; }
        public string Messages { get; set; }
        public string SourceSocmed { get; set; }
        public string StatusType { get; set; }
        public DateTime? DateGetSosmed { get; set; }
        public DateTime? DateCreate { get; set; }
        public string Active { get; set; }
    }
}
