using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class UideskTicketReminder
    {
        public int Id { get; set; }
        public string TicketNumber { get; set; }
        public string JudulReminder { get; set; }
        public DateTime? TanggalReminder { get; set; }
        public string DescriptionReminder { get; set; }
        public string UserCreate { get; set; }
        public DateTime? DateCreate { get; set; }
    }
}
