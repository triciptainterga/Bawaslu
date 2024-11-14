using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class TrReleaseLog
    {
        public int Id { get; set; }
        public string TicketNumber { get; set; }
        public string ReleaseType { get; set; }
        public string ReleaseUser { get; set; }
        public string ReleaseFromLayer { get; set; }
        public string ReleaseToLayer { get; set; }
        public string ReleaseReason { get; set; }
        public string ReleaseBy { get; set; }
        public DateTime? ReleaseDate { get; set; }
    }
}
