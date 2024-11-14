using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class UideskTempNoteInternal
    {
        public int Id { get; set; }
        public string Ticketnumber { get; set; }
        public string Note { get; set; }
        public string Usercreate { get; set; }
        public DateTime? Datecreate { get; set; }
    }
}
