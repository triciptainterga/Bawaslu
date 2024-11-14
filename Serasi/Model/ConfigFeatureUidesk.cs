using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class ConfigFeatureUidesk
    {
        public int Id { get; set; }
        public string ConfigName { get; set; }
        public int? ConfigVal { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string ConfigStatus { get; set; }
    }
}
