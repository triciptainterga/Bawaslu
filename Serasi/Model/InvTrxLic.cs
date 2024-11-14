using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class InvTrxLic
    {
        public int Id { get; set; }
        public string UserLogin { get; set; }
        public string NameChannel { get; set; }
        public DateTime? DateLicUsed { get; set; }
    }
}
