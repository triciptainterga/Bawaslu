using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class UideskTrxLogReleaseLogin
    {
        public int ReleaseId { get; set; }
        public string ReleaseUser { get; set; }
        public string ReleaseCreated { get; set; }
        public string ReleaseType { get; set; }
        public DateTime? ReleaseDate { get; set; }
    }
}
