using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class SocialMediaDetailReply
    {
        public int Id { get; set; }
        public string DetailSosmedReply { get; set; }
        public string DetailSosmed { get; set; }
        public string HeaderSosmed { get; set; }
        public string FlagTo { get; set; }
        public string ProfileId { get; set; }
        public string ProfileName { get; set; }
        public string ProfileEmail { get; set; }
        public string Messages { get; set; }
        public string MediaUrl { get; set; }
        public string StatusType { get; set; }
        public string SourceSocmed { get; set; }
        public DateTime? DateGetSosmed { get; set; }
        public DateTime? DateCreate { get; set; }
        public string Active { get; set; }
        public string TicketNumber { get; set; }
    }
}
