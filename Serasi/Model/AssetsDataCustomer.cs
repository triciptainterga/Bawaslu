using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class AssetsDataCustomer
    {
        public int Id { get; set; }
        public string CusTomerId { get; set; }
        public string AId { get; set; }
        public string CreaTedBy { get; set; }
        public DateTime? CreaTedDate { get; set; }
    }
}
