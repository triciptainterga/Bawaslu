using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class TrThreadActivity
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string ChannelId { get; set; }
        public string ChannelName { get; set; }
        public DateTime? DateLastInteraction { get; set; }
    }
}
