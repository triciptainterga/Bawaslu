using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class TeleTrxProduk
    {
        public int Id { get; set; }
        public string Telepon { get; set; }
        public string HeaderId { get; set; }
        public string ProdukId { get; set; }
        public string ProdukName { get; set; }
        public string DetailProdukId { get; set; }
        public string DetailProdukName { get; set; }
        public DateTime? JatuhTempo { get; set; }
        public string TeleponHubungan { get; set; }
        public string Hubungan { get; set; }
        public string Keterangan { get; set; }
        public string StatusData { get; set; }
        public string CreateBy { get; set; }
        public DateTime? DateCreate { get; set; }
    }
}
