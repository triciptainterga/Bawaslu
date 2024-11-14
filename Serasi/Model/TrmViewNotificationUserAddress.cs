using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class TrmViewNotificationUserAddress
    {
        public int Id { get; set; }
        public string EmailAddress { get; set; }
        public string TicketCreate { get; set; }
        public string TicketOverSla { get; set; }
        public string TicketClosed { get; set; }
        public string Usercreate { get; set; }
        public DateTime? Datecreate { get; set; }
        public string Status { get; set; }
        public string Department { get; set; }
        public string Vendor { get; set; }
        public string TicketEskalasi { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
    }
}
