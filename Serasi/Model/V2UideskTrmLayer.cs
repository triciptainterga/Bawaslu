using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class V2UideskTrmLayer
    {
        public int Id { get; set; }
        public int? Layer { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateCreated { get; set; }
    }
}
