using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class BtnStatusPelapor
    {
        public int Id { get; set; }
        public string StatusName { get; set; }
        public string DescName { get; set; }
        public string Na { get; set; }
        public string Usercreate { get; set; }
        public DateTime? Datecreate { get; set; }
        public string Userupdate { get; set; }
        public DateTime? Dateupdate { get; set; }
    }
}
