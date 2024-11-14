using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class XtraLoginActivity
    {
        public int Id { get; set; }
        public string Agent { get; set; }
        public string Description { get; set; }
        public string UserName { get; set; }
        public DateTime? DateCreate { get; set; }
        public string DateLogin { get; set; }
    }
}
