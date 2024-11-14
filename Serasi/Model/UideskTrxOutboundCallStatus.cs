using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class UideskTrxOutboundCallStatus
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public string Createdby { get; set; }
        public DateTime? Createddate { get; set; }
    }
}
