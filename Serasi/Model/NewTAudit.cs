using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class NewTAudit
    {
        public int AuditTrialId { get; set; }
        public string UserUse { get; set; }
        public DateTime? DateUse { get; set; }
        public string ModuleUse { get; set; }
        public string ActivityUse { get; set; }
        public string UserRole { get; set; }
        public string DescriptionUse { get; set; }
    }
}
