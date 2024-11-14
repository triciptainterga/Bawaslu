using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class Mtroleuser
    {
        public int RoleId { get; set; }
        public string RoleUser { get; set; }
        public string Description { get; set; }
        public int? NumberNya { get; set; }
        public string Na { get; set; }
    }
}
