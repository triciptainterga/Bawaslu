using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class MasterParam
    {
        public int Id { get; set; }
        public DateTime? DateReal { get; set; }
        public int? Status { get; set; }
        public string Untuk { get; set; }
        public DateTime? DateCreate { get; set; }
        public string UserCreate { get; set; }
    }
}
