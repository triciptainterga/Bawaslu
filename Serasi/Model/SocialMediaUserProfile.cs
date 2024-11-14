using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class SocialMediaUserProfile
    {
        public int Id { get; set; }
        public string SocialMediaId { get; set; }
        public string SocialMediaName { get; set; }
        public string SocialMediaType { get; set; }
        public string SocialMediaPhoto { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateUpdate { get; set; }
        public string SocialMediaCharacter { get; set; }
    }
}
