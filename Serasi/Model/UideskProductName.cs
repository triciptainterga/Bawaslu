using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class UideskProductName
    {
        public int Id { get; set; }
        public int? ProductTypeId { get; set; }
        public string ProductName { get; set; }
        public string ProductCreated { get; set; }
        public DateTime? ProductDated { get; set; }
        public string ProductStatus { get; set; }
    }
}
