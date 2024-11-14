using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class PbxVQstatsFull
    {
        public int? QueueStatsId { get; set; }
        public string Uniqueid { get; set; }
        public DateTime? Datetime { get; set; }
        public int? Qname { get; set; }
        public int? Qagent { get; set; }
        public int? Qevent { get; set; }
        public string Info1 { get; set; }
        public string Info2 { get; set; }
        public string Info3 { get; set; }
        public string Info4 { get; set; }
        public string Info5 { get; set; }
        public string Event { get; set; }
        public string Agent { get; set; }
        public string Queue { get; set; }
    }
}
