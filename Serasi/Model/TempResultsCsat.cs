using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class TempResultsCsat
    {
        public string TicketNumber { get; set; }
        public string Channel { get; set; }
        public string ValueDetail { get; set; }
        public string ResultCsat { get; set; }
        public string CustomerName { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
