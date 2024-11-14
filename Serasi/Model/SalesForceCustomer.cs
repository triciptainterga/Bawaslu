using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class SalesForceCustomer
    {
        public string ContactName { get; set; }
        public string Mobile { get; set; }
        public string Kota { get; set; }
        public DateTime? DateCreate { get; set; }
        public string State { get; set; }
    }
}
