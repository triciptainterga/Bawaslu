using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class IccAuxHistory
    {
        public int Id { get; set; }
        public string Userid { get; set; }
        public DateTime? Auxdate { get; set; }
        public string Auxid { get; set; }
        public string Auxdescription { get; set; }
        public string State { get; set; }
        public DateTime? Datecreate { get; set; }
    }
}
