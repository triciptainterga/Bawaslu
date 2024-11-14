using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class VwEmailListRelease
    {
        public long? RowNum { get; set; }
        public string JenisNotif { get; set; }
        public string JenisKategori { get; set; }
        public string JenisRelated { get; set; }
        public string LayerId { get; set; }
    }
}
