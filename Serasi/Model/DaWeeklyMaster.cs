using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class DaWeeklyMaster
    {
        public long Id { get; set; }
        public string AgentName { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
