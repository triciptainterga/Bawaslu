using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class SocialMediaGetHashtag
    {
        public int Id { get; set; }
        public string SourceSocialMedia { get; set; }
        public string SocialPostId { get; set; }
        public string Hashtags { get; set; }
        public string AccountId { get; set; }
        public string AccountName { get; set; }
        public DateTime? DateCreate { get; set; }
        public string Status { get; set; }
    }
}
