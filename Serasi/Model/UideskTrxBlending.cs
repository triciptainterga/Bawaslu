using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class UideskTrxBlending
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string ChannelId { get; set; }
        public string ChannelName { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public int? MaxHandle { get; set; }
        public int? NowHandle { get; set; }
        public string UserCreate { get; set; }
        public DateTime? DateCreate { get; set; }
        public string UserUpdate { get; set; }
        public DateTime? DateUpdate { get; set; }
        public string Active { get; set; }
    }
}
