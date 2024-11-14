using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class AppsUideskQuotation
    {
        public int Id { get; set; }
        public string TransaksiId { get; set; }
        public string Subject { get; set; }
        public string Number { get; set; }
        public string Note { get; set; }
        public string Versi { get; set; }
        public decimal? Total { get; set; }
        public string Files { get; set; }
        public string UserCreate { get; set; }
        public DateTime? DateCreate { get; set; }
    }
}
