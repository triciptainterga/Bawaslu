using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class UideskSocialAccount
    {
        public int Id { get; set; }
        public string AccountToken { get; set; }
        public string AccountId { get; set; }
        public string AccountName { get; set; }
        public string AccountUrl { get; set; }
        public string SocialMedia { get; set; }
        public string Webhook { get; set; }
        public string SourceId { get; set; }
        public string Active { get; set; }
    }
}
