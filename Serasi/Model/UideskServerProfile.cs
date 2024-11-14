using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class UideskServerProfile
    {
        public int RecId { get; set; }
        public string Name { get; set; }
        public string ServerName { get; set; }
        public string DbName { get; set; }
        public string UserLogin { get; set; }
        public string Password { get; set; }
    }
}
