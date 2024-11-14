using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class IccCallTemp
    {
        public decimal Id { get; set; }
        public string Phone { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int? Flag { get; set; }
        public string Channel { get; set; }
    }
}
