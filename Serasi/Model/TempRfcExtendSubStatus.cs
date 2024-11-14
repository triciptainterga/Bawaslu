using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class TempRfcExtendSubStatus
    {
        public int Id { get; set; }
        public string CategoryId { get; set; }
        public string StatusId { get; set; }
        public string NameStatus { get; set; }
        public int? Sla { get; set; }
        public int? Sla1 { get; set; }
        public string Na { get; set; }
        public DateTime? DateCreate { get; set; }
        public string UserCreate { get; set; }
        public DateTime? DateUpdate { get; set; }
        public string UserUpdate { get; set; }
    }
}
