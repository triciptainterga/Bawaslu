using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class V2UideskTrxTableDashboardOutboundDuration
    {
        public int Id { get; set; }
        public string AgentName { get; set; }
        public int? TotalCall { get; set; }
        public int? ConvertSecond { get; set; }
        public string StatusAgent { get; set; }
        public string UserName { get; set; }
        public DateTime? DateCreated { get; set; }
    }
}
