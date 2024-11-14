using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class BtnTrxTicketFile
    {
        public int Id { get; set; }
        public string TicketNumber { get; set; }
        public string FileName { get; set; }
        public string JudulAttchmen { get; set; }
        public string UserCreate { get; set; }
        public DateTime? DateCreate { get; set; }
    }
}
