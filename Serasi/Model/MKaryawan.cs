using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class MKaryawan
    {
        public int Id { get; set; }
        public string Nik { get; set; }
        public string Name { get; set; }
        public string Handphone { get; set; }
        public string Email { get; set; }
        public string JenisKelamin { get; set; }
        public DateTime? TanggalLahir { get; set; }
        public string Address { get; set; }
        public string Divisi { get; set; }
        public string MasaKerja { get; set; }
        public string Path { get; set; }
        public string Usercreate { get; set; }
        public DateTime? Datecreate { get; set; }
        public string Userupdate { get; set; }
        public DateTime? Dateupdate { get; set; }
    }
}
