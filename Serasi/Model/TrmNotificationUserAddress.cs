using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class TrmNotificationUserAddress
    {
        public string StatusUser { get; set; }
        public int Userid { get; set; }
        public string Name { get; set; }
        public string Organization { get; set; }
        public string NamaGrup { get; set; }
        public string Unitkerja { get; set; }
        public string Leveluser { get; set; }
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
        public string OrganizationName { get; set; }
    }
}
