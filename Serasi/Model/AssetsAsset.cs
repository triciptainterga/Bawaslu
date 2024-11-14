using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class AssetsAsset
    {
        public AssetsAsset()
        {
            AssetsBorrowRequests = new HashSet<AssetsBorrowRequest>();
        }

        public int AId { get; set; }
        public string AssetName { get; set; }
        public string Description { get; set; }
        public string Weight { get; set; }
        public DateTime DateOfPurchase { get; set; }
        public decimal Price { get; set; }
        public int? DId { get; set; }
        public int? BId { get; set; }
        public string AccessionNo { get; set; }
        public string BillNo { get; set; }
        public string VendorName { get; set; }
        public string VendorAddress { get; set; }
        public string Status { get; set; }
        public string Warranty { get; set; }
        public DateTime? DateOfAllocate { get; set; }

        public virtual ICollection<AssetsBorrowRequest> AssetsBorrowRequests { get; set; }
    }
}
