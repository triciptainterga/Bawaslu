using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class IvcUserIn
    {
        public string UserName { get; set; }
        public string Authority { get; set; }
        public string Role { get; set; }
        public string Linkstate { get; set; }
        public string Password { get; set; }
        public bool? Inbound { get; set; }
        public bool? Outbound { get; set; }
        public bool? Fax { get; set; }
        public bool? Sms { get; set; }
        public bool? Email { get; set; }
        public bool? Facebook { get; set; }
        public bool? Twitter { get; set; }
        public bool? Admintool { get; set; }
        public bool? Smsblast { get; set; }
        public bool? Chat { get; set; }
        public int? HandleChat { get; set; }
        public string Leveluser { get; set; }
        public string State { get; set; }
        public bool? Whatsapp { get; set; }
        public int? Login { get; set; }
        public string Organization { get; set; }
        public int? MaxChat { get; set; }
        public int? MaxQueue { get; set; }
        public string IdAux { get; set; }
    }
}
