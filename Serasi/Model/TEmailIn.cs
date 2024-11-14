using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class TEmailIn
    {
        public decimal Id { get; set; }
        public string EmailId { get; set; }
        public string Efrom { get; set; }
        public string Eto { get; set; }
        public string Ecc { get; set; }
        public string Ebcc { get; set; }
        public string Esubject { get; set; }
        public string EbodyText { get; set; }
        public string EbodyHtml { get; set; }
        public DateTime? EmailDate { get; set; }
    }
}
