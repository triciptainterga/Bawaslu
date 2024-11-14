using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class IccTimestamp
    {
        public int Id { get; set; }
        public string Menu { get; set; }
        public string Username { get; set; }
        public string Activity { get; set; }
        public DateTime? Datecreate { get; set; }
    }
}
