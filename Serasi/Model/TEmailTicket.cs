using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class TEmailTicket
    {
        public int Id { get; set; }
        public string TicketNumber { get; set; }
        public string EmailTo { get; set; }
        public string EmailFrom { get; set; }
        public string EmailSubject { get; set; }
        public string CategoryId { get; set; }
        public string SubCategory1Id { get; set; }
        public string SubCategory2Id { get; set; }
        public string SubCategory3Id { get; set; }
        public string EmailBody { get; set; }
        public string Na { get; set; }
    }
}
