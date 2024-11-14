using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class IccLdapSetting
    {
        public int Id { get; set; }
        public string Ldapserver { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime? Datecreate { get; set; }
        public string Na { get; set; }
        public string EmailAtasan { get; set; }
    }
}
