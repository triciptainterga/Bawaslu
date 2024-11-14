using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class PbxVQstatsReportmonthly
    {
        public decimal? Id { get; set; }
        public int Urutan { get; set; }
        public string Labelreport { get; set; }
        public DateTime? RegDate { get; set; }
        public string EventId { get; set; }
    }
}
