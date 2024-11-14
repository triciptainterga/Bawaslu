using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class PbxVQstatsAll
    {
        public decimal? Id { get; set; }
        public DateTime? Datetime { get; set; }
        public DateTime? Datetimeconnect { get; set; }
        public DateTime? Datetimeend { get; set; }
        public string Queue { get; set; }
        public string Agent { get; set; }
        public string Event { get; set; }
        public string Uniqueid { get; set; }
        public string RealUniqueid { get; set; }
        public string Clid { get; set; }
        public string Url { get; set; }
        public string Did { get; set; }
        public decimal Position { get; set; }
        public string Info1 { get; set; }
        public string Info2 { get; set; }
        public string Info3 { get; set; }
        public string Info4 { get; set; }
        public string Info5 { get; set; }
        public decimal Overflow { get; set; }
        public decimal CombinedWaittime { get; set; }
        public decimal Waittime { get; set; }
        public decimal Talktime { get; set; }
        public decimal Ringtime { get; set; }
    }
}
