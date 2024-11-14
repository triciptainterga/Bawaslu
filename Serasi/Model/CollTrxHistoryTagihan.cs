using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class CollTrxHistoryTagihan
    {
        public int Id { get; set; }
        public string Telepon { get; set; }
        public decimal? JumlahTagihan { get; set; }
        public string PeriodeTagihan { get; set; }
        public string MetodePembayaran { get; set; }
        public string Status { get; set; }
        public DateTime? TanggalBayar { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateCreate { get; set; }
    }
}
