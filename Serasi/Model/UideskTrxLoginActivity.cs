using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class UideskTrxLoginActivity
    {
        public int Id { get; set; }
        public int? LoginId { get; set; }
        public string LoginDescription { get; set; }
        public string LoginUserName { get; set; }
        public string LoginPassword { get; set; }
        public string LoginBrowser { get; set; }
        public string LoginChannel { get; set; }
        public string LoginIpaddress { get; set; }
        public DateTime? LoginDate { get; set; }
    }
}
