using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class TempTrxChangePswd
    {
        public int Id { get; set; }
        public string TrxPassword { get; set; }
        public string TrxNewPassword { get; set; }
        public string TrxUsername { get; set; }
        public DateTime? TrxDate { get; set; }
    }
}
