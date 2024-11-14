using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class AssetsBill
    {
        public int BId { get; set; }
        public string BillNo { get; set; }
        public string VendorName { get; set; }
        public string VendorAddress { get; set; }
        public string JenisKelamin { get; set; }
    }
}
