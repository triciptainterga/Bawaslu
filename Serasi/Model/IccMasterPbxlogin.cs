using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class IccMasterPbxlogin
    {
        public int Id { get; set; }
        public string Pbxlogin { get; set; }
        public string Pbxlogout { get; set; }
        public string Pbxaux { get; set; }
        public string Pbxin { get; set; }
        public string Pbxacw { get; set; }
    }
}
