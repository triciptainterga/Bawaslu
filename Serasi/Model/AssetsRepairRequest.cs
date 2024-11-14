using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class AssetsRepairRequest
    {
        public int RrId { get; set; }
        public int AId { get; set; }
        public DateTime DateOfRequest { get; set; }
        public DateTime? DateOfApproval { get; set; }
        public decimal AmountEst { get; set; }
        public decimal? AmountActual { get; set; }
        public string ReqStatus { get; set; }
    }
}
