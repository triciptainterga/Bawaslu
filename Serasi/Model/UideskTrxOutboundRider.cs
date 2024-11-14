using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class UideskTrxOutboundRider
    {
        public int Id { get; set; }
        public string CallUploadId { get; set; }
        public string CallPolisNumber { get; set; }
        public string CallManfaat { get; set; }
        public decimal? CallNominal { get; set; }
        public string CallCreated { get; set; }
        public DateTime? CallDate { get; set; }
    }
}
