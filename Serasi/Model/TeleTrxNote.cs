using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class TeleTrxNote
    {
        public int Id { get; set; }
        public string HeaderId { get; set; }
        public string Note { get; set; }
        public string Status { get; set; }
        public string EskalasiTicket { get; set; }
        public string CreateBy { get; set; }
        public DateTime? DateCreate { get; set; }
    }
}
