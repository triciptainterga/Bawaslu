using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class TrLdapSetting
    {
        public int Id { get; set; }
        public string Ldapurl { get; set; }
        public string Usercreate { get; set; }
        public DateTime? Datecreate { get; set; }
    }
}
