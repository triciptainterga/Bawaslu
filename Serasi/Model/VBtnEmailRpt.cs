using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class VBtnEmailRpt
    {
        public string EmailId { get; set; }
        public string Efrom { get; set; }
        public string Esubject { get; set; }
        public string Agent { get; set; }
        public string EbodyText { get; set; }
        public string Incoming { get; set; }
        public string Outgoing { get; set; }
        public string Blanding { get; set; }
    }
}
