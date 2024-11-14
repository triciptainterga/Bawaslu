using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class DatakelolaPostMedium
    {
        public decimal? Id { get; set; }
        public string SourceTable { get; set; }
        public string SourceId { get; set; }
        public string UrlOrigin { get; set; }
        public string UrlLocal { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
