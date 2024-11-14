using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class UideskTrxOutboundSummary
    {
        public int Id { get; set; }
        public string CallUploadId { get; set; }
        public string CallUploadType { get; set; }
        public string CallUploadFilename { get; set; }
        public int? CallApiRows { get; set; }
        public int? CallUploadRows { get; set; }
        public string CallUploadCreated { get; set; }
        public DateTime? CallUploadDate { get; set; }
    }
}
