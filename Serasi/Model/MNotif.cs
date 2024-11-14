using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class MNotif
    {
        public int Id { get; set; }
        public string ParamAwal { get; set; }
        public string ParamIsi { get; set; }
        public string ParamAkhir { get; set; }
        public string ParamSearch { get; set; }
    }
}
