using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class TeleTrmKategoriProduk
    {
        public int Id { get; set; }
        public string Produk { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateCreate { get; set; }
    }
}
