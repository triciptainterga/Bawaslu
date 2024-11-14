using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class MItemPenilaian
    {
        public int Id { get; set; }
        public string KodeAlatTest { get; set; }
        public string KodePertanyaan { get; set; }
        public string KodePenilaian { get; set; }
        public string NamaPenilaian { get; set; }
        public int? Nilai { get; set; }
        public string NoUrut { get; set; }
        public string Aktif { get; set; }
        public string Usercreate { get; set; }
        public DateTime? Datecreate { get; set; }
        public string Userupdate { get; set; }
        public DateTime? Dateupdate { get; set; }
    }
}
