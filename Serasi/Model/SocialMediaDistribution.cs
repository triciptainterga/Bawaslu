using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class SocialMediaDistribution
    {
        public int Id { get; set; }
        public string SocialMediaHeaderId { get; set; }
        public string SocialMediaType { get; set; }
        public string AgentId { get; set; }
        public DateTime? DateCreate { get; set; }
    }
}
