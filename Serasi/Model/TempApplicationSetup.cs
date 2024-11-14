using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class TempApplicationSetup
    {
        public int Id { get; set; }
        public string Menu { get; set; }
        public string Url { get; set; }
        public DateTime? Datecreate { get; set; }
    }
}
