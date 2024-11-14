using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class TeleTrxDashboard
    {
        public int Id { get; set; }
        public string AgentName { get; set; }
        public int? DistributeCall { get; set; }
        public int? DataCall { get; set; }
        public int? DataNotCall { get; set; }
        public int? CompleteCall { get; set; }
        public int? AnotherCall { get; set; }
        public string Type { get; set; }
        public string UserName { get; set; }
        public DateTime? DateCreated { get; set; }
    }
}
