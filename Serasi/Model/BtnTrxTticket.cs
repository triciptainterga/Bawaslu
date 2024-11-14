using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class BtnTrxTticket
    {
        public int Id { get; set; }
        public string TicketNumber { get; set; }
        public DateTime? TglKejadian { get; set; }
        public string IdPenyebab { get; set; }
        public string StrPenyebab { get; set; }
        public string StrPenerima { get; set; }
        public string IdStatusPelapor { get; set; }
        public string StrStatusPelapor { get; set; }
        public string LokasiPengaduan { get; set; }
        public string SkalaPrioritas { get; set; }
        public string JenisNasabah { get; set; }
        public string Flag { get; set; }
    }
}
