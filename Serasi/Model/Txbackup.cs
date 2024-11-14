using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class Txbackup
    {
        public decimal Id { get; set; }
        public string Sourcepath { get; set; }
        public string Destinationpath { get; set; }
        public string Totalrecord { get; set; }
        public string Totalrecordexecute { get; set; }
        public string Deletefile { get; set; }
        public DateTime? Backupdate { get; set; }
        public string Startdate { get; set; }
        public string Enddate { get; set; }
        public string Hours { get; set; }
    }
}
