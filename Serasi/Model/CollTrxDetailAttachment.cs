using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class CollTrxDetailAttachment
    {
        public int Id { get; set; }
        public string HeaderId { get; set; }
        public string DetailId { get; set; }
        public string FileNameUrl { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateCreated { get; set; }
    }
}
