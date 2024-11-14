using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class TempParentNumberId
    {
        public int Id { get; set; }
        public string TicketNumber { get; set; }
        public string ParentNumberId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string NoteAction { get; set; }
        public string ReasonParent { get; set; }
    }
}
