using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class SmlMCustomerChannel
    {
        public int Id { get; set; }
        public string CustomerId { get; set; }
        public string FlagChannel { get; set; }
        public string ValueChannel { get; set; }
        public DateTime? DateCreate { get; set; }
        public string UserCreate { get; set; }
        public DateTime? DateUpdate { get; set; }
        public string UserUpdate { get; set; }
        public string Status { get; set; }
    }
}
