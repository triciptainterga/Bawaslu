using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class IccMasterPbxuser
    {
        public string UserId { get; set; }
        public int? LoginId { get; set; }
        public int? Password { get; set; }
        public string Desc { get; set; }
    }
}
