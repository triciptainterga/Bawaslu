using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class FeatureNotaInteraction
    {
        public int Id { get; set; }
        public string NomorNota { get; set; }
        public string Username { get; set; }
        public string UserPosition { get; set; }
        public DateTime? DatePosition { get; set; }
        public string StatusDisposition { get; set; }
        public DateTime? DateDisposition { get; set; }
        public string StatusNota { get; set; }
        public string Keterangan { get; set; }
    }
}
