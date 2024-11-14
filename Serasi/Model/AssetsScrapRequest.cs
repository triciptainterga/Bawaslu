using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class AssetsScrapRequest
    {
        public int SrId { get; set; }
        public DateTime? DateOfRequest { get; set; }
        public DateTime? DateOfApproval { get; set; }
        public decimal? AmountReleased { get; set; }
        public decimal? AmountWrittenOff { get; set; }
        public int? AId { get; set; }
        public string ReqStatus { get; set; }
    }
}
