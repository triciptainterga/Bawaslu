using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class TempResultsSm
    {
        public string Phonenumber { get; set; }
        public string Message { get; set; }
        public string FlagDescription { get; set; }
        public string StsDescription { get; set; }
        public string CampaintName { get; set; }
        public DateTime? DateCreate { get; set; }
    }
}
