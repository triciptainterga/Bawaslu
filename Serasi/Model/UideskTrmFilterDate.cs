using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class UideskTrmFilterDate
    {
        public int Id { get; set; }
        public string Startdate { get; set; }
        public string Enddate { get; set; }
        public string Username { get; set; }
        public DateTime? Datecreate { get; set; }
    }
}
