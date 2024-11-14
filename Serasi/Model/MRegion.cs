using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class MRegion
    {
        public int Id { get; set; }
        public string RegionId { get; set; }
        public string RegionName { get; set; }
        public string RegionDesc { get; set; }
        public string RegionStatus { get; set; }
    }
}
