using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class BtnDataKantorOld
    {
        public int Id { get; set; }
        public double? Kode1 { get; set; }
        public string Kode2 { get; set; }
        public double? Kode3 { get; set; }
        public string Nama { get; set; }
        public string Kanwil { get; set; }
        public string Kode { get; set; }
        public string NamaDaerah { get; set; }
        public string Jenis { get; set; }
        public string Alamat { get; set; }
        public string KantorCabang { get; set; }
        public string NoTelp { get; set; }
    }
}
