using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class AppemailLogActivity
    {
        public int RecId { get; set; }
        public string AppVer { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
