using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class DaWeeklyDetail
    {
        public long Id { get; set; }
        public long DaWeeklyMasterId { get; set; }
        public string Type { get; set; }
        public int Senin { get; set; }
        public int Selasa { get; set; }
        public int Rabu { get; set; }
        public int Kamis { get; set; }
        public int Jumat { get; set; }
        public int Sabtu { get; set; }
        public int Minggu { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string AgentName { get; set; }
    }
}
