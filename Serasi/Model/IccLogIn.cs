using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class IccLogIn
    {
        public int Id { get; set; }
        public string Userid { get; set; }
        public DateTime? ActivityDate { get; set; }
        public string AuxDescription { get; set; }
        public DateTime? Datecreate { get; set; }
    }
}
