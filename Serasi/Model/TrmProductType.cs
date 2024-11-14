using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class TrmProductType
    {
        public string Status { get; set; }
        public int Id { get; set; }
        public string IdPenyebab { get; set; }
        public string NamaPenyebab { get; set; }
        public string UserCreate { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateUpdate { get; set; }
        public string Na { get; set; }
    }
}
