using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class SocialMediaLogInteraction
    {
        public int Id { get; set; }
        public string SocialMediaId { get; set; }
        public string SocialChannel { get; set; }
        public string SocialDesc { get; set; }
        public DateTime? DateTimeSocial { get; set; }
        public string Agentname { get; set; }
        public string SocialAccount { get; set; }
        public string StatusData { get; set; }
    }
}
