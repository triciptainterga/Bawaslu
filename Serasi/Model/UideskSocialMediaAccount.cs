using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class UideskSocialMediaAccount
    {
        public int Id { get; set; }
        public string NameNya { get; set; }
        public string Username { get; set; }
        public string IsBusinessFollowUser { get; set; }
        public string ProfilePic { get; set; }
        public string IsVerifiedUser { get; set; }
        public int? FollowerCount { get; set; }
        public string Idnya { get; set; }
        public string IsUserFollowBusiness { get; set; }
        public string SocialMedia { get; set; }
    }
}
