using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class BtnReasonCall
    {
        public int Id { get; set; }
        public string Kode { get; set; }
        public string ReasonCall { get; set; }
        public string Usercreate { get; set; }
        public DateTime? Datecreate { get; set; }
        public string Na { get; set; }
        public string Color { get; set; }
    }
}
