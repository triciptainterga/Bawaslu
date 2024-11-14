using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class DatakelolaPost
    {
        public string Jenis { get; set; }
        public string PostId { get; set; }
        public string PageId { get; set; }
        public string ProfileId { get; set; }
        public string Messages { get; set; }
        public DateTime? GettimeSocmedAt { get; set; }
        public string StatusType { get; set; }
        public string SourceSocmed { get; set; }
        public decimal? IsActive { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
