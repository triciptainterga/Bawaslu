using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class UideskTrxOutboundFund
    {
        public int Id { get; set; }
        public string CallUploadId { get; set; }
        public string CallPolisNumber { get; set; }
        public string CallJenisInvestasi { get; set; }
        public string CallCreated { get; set; }
        public DateTime? CallDate { get; set; }
        public string CallPersentaseAlokasi { get; set; }
    }
}
