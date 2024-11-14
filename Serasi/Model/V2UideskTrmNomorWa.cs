using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class V2UideskTrmNomorWa
    {
        public int Id { get; set; }
        public string NomorWa { get; set; }
        public string Site { get; set; }
        public string Status { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateCreated { get; set; }
    }
}
