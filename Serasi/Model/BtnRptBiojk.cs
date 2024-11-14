using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class BtnRptBiojk
    {
        public int Id { get; set; }
        public string IdBi { get; set; }
        public string IdOjk { get; set; }
        public string UserCreate { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateUpdate { get; set; }
        public string Na { get; set; }
    }
}
