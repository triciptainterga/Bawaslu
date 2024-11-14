using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class MItemPertanyaan
    {
        public int Id { get; set; }
        public string KodeGrup { get; set; }
        public string KodePertanyaan { get; set; }
        public int? NoUrut { get; set; }
        public string ItemPertanyaan { get; set; }
        public string DiscM { get; set; }
        public string DiscL { get; set; }
        public int? Bobot { get; set; }
        public string Aktif { get; set; }
        public string UserCreate { get; set; }
        public DateTime? DateCreate { get; set; }
    }
}
