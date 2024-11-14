using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class OutTrxDashboardDuration
    {
        public int Id { get; set; }
        public string AgentName { get; set; }
        public int? TotalCall { get; set; }
        public string ConvertSecond { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string CallType { get; set; }
        public string StatusAgent { get; set; }
        public string UserName { get; set; }
        public DateTime? DateCreated { get; set; }
    }
}
