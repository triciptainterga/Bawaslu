using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class TempTrxCsat
    {
        public int Id { get; set; }
        public string UniqueId { get; set; }
        public string TicketNumber { get; set; }
        public string Channel { get; set; }
        public DateTime? DateCsat { get; set; }
        public string ResultCsat { get; set; }
        public string UserName { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
