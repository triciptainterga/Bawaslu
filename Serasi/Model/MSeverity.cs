using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class MSeverity
    {
        public int Id { get; set; }
        public string Jenis { get; set; }
        public DateTime? Date { get; set; }
    }
}
