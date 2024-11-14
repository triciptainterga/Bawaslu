using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class UideskTrmAux
    {
        public int Id { get; set; }
        public string Deskripsi { get; set; }
        public string Na { get; set; }
        public string Usercreate { get; set; }
        public DateTime? Datecreate { get; set; }
        public string Userupdate { get; set; }
        public DateTime? Dateupdate { get; set; }
        public string TimeLimit { get; set; }
        public string AuxType { get; set; }
    }
}
