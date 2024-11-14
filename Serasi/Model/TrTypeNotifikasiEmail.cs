using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class TrTypeNotifikasiEmail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string State { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
