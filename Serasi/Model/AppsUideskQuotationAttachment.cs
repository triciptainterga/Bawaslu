using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class AppsUideskQuotationAttachment
    {
        public int Id { get; set; }
        public string TransaksiId { get; set; }
        public string QuotationId { get; set; }
        public string Url { get; set; }
        public string Foldername { get; set; }
        public string Filename { get; set; }
        public string Extension { get; set; }
        public string Size { get; set; }
        public string Status { get; set; }
        public string Usercreate { get; set; }
        public DateTime? Datecreate { get; set; }
    }
}
