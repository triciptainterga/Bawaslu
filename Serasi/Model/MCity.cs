using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class MCity
    {
        public int Id { get; set; }
        public string RegionId { get; set; }
        public string CityId { get; set; }
        public string CityName { get; set; }
        public string CityDesc { get; set; }
        public string CityStatus { get; set; }
    }
}
