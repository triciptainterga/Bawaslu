using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class BtnMOjk
    {
        public int IdOjk { get; set; }
        public string KodeReport { get; set; }
        public string NameReport { get; set; }
        public string Na { get; set; }
        public DateTime? DateCreate { get; set; }
        public string UserCreate { get; set; }
        public DateTime? DateUpdate { get; set; }
    }
}
