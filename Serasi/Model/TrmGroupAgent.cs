using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class TrmGroupAgent
    {
        public string Status { get; set; }
        public int IdGrup { get; set; }
        public string NamaGrup { get; set; }
        public string Description { get; set; }
        public string Na { get; set; }
        public string UserCreate { get; set; }
        public DateTime? DateCreate { get; set; }
    }
}
