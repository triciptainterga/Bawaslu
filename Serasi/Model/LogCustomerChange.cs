using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class LogCustomerChange
    {
        public int LogId { get; set; }
        public string Username { get; set; }
        public DateTime? LogTime { get; set; }
        public string ActivityUser { get; set; }
        public string ValueBefore { get; set; }
        public string ValueAfter { get; set; }
        public string CustomerId { get; set; }
    }
}
