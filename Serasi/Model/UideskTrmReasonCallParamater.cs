using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class UideskTrmReasonCallParamater
    {
        public int Id { get; set; }
        public int? CallJumlah { get; set; }
        public string CallCreated { get; set; }
        public DateTime? CallDated { get; set; }
    }
}
