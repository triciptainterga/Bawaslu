using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class TrmUserAdd
    {
        public string Status { get; set; }
        public int Userid { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Organization { get; set; }
        public string Unitkerja { get; set; }
        public string Leveluser { get; set; }
        public string EmailAddress { get; set; }
        public string Usercreate { get; set; }
        public string Na { get; set; }
        public DateTime? Datecreate { get; set; }
        public string OrganizationName { get; set; }
        public string NamaGrup { get; set; }
        public bool? Email { get; set; }
        public bool? Sms { get; set; }
        public bool? Whatsapp { get; set; }
        public bool? Facebook { get; set; }
        public bool? Twitter { get; set; }
        public long? Instagram { get; set; }
        public bool? Outbound { get; set; }
        public bool? Chat { get; set; }
        public bool? Inbound { get; set; }
        public string Description { get; set; }
        public string Site { get; set; }
        public string TokenMeta { get; set; }
    }
}
