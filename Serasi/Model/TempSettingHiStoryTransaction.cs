using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class TempSettingHiStoryTransaction
    {
        public int Id { get; set; }
        public int? Day { get; set; }
        public DateTime? FilterDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string Type { get; set; }
    }
}
