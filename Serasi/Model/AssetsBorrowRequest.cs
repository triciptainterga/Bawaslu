using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class AssetsBorrowRequest
    {
        public int BrId { get; set; }
        public int AId { get; set; }
        public int? RequestingDeptId { get; set; }
        public DateTime DateOfRequest { get; set; }
        public DateTime DateOfPickup { get; set; }
        public DateTime DateOfReturn { get; set; }
        public string ReqStatus { get; set; }
        public DateTime? DateOfApproval { get; set; }

        public virtual AssetsAsset AIdNavigation { get; set; }
    }
}
