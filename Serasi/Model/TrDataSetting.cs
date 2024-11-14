using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class TrDataSetting
    {
        public int Id { get; set; }
        public int? Value { get; set; }
        public string Type { get; set; }
        public DateTime? DateBy { get; set; }
        public string CreatedBy { get; set; }
    }
}
