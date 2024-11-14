using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class TaurusMEscalationType
    {
        public int Id { get; set; }
        public string NameEscalation { get; set; }
        public string Description { get; set; }
        public string UserCreate { get; set; }
        public DateTime? DateCreate { get; set; }
        public string UserUpdate { get; set; }
        public DateTime? DateUpdate { get; set; }
        public string Na { get; set; }
    }
}
