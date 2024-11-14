using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class AhuUideskTrxAssignEmailLog
    {
        public int Id { get; set; }
        public string AssignId { get; set; }
        public string AssignFrom { get; set; }
        public string AssignTo { get; set; }
        public string AssignReason { get; set; }
        public string AssignUser { get; set; }
        public string AssignType { get; set; }
        public DateTime? DateCreate { get; set; }
    }
}
