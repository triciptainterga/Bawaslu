using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class SlaTicket
    {
        public int Id { get; set; }
        public string Feature { get; set; }
        public int? Sla { get; set; }
        public string Type { get; set; }
        public string Category { get; set; }
        public string Jenis { get; set; }
        public string UserCreate { get; set; }
        public DateTime? DateCreate { get; set; }
        public string UserUpdate { get; set; }
        public DateTime? DateUpdate { get; set; }
    }
}
