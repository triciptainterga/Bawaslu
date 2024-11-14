using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class MAlatTest
    {
        public int Id { get; set; }
        public string KodeAlatTest { get; set; }
        public string NamaAlatTest { get; set; }
        public string Aktif { get; set; }
        public string UserUpdate { get; set; }
        public DateTime? DateUpdate { get; set; }
        public string UserCreate { get; set; }
        public DateTime? DateCreate { get; set; }
    }
}
