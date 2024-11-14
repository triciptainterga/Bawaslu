using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class UideskMergeTicket
    {
        public int Id { get; set; }
        public string TicketGroup { get; set; }
        public string TicketNumber { get; set; }
        public DateTime? WaktuPenggabungan { get; set; }
        public string StatusSebelum { get; set; }
        public string UserCreate { get; set; }
        public DateTime? DateCreate { get; set; }
        public string Na { get; set; }
    }
}
