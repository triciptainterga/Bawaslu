using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class UideskTrmEscalationIndividu
    {
        public int Id { get; set; }
        public string TicketNumber { get; set; }
        public string TrxUserName { get; set; }
        public string TrxFlag { get; set; }
        public string TrxInteractionId { get; set; }
        public string TrxUserCreate { get; set; }
        public DateTime? TrxDateCreate { get; set; }
        public string TrxDepartment { get; set; }
        public string Notifikasi { get; set; }
    }
}
