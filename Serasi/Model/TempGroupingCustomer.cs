using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class TempGroupingCustomer
    {
        public int Id { get; set; }
        public string TrxFromCustomerId { get; set; }
        public string TrxToCustomerId { get; set; }
        public string UserCreate { get; set; }
        public DateTime? DateCreate { get; set; }
    }
}
