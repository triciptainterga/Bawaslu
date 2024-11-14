using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class Txbackupsetup
    {
        public decimal Id { get; set; }
        public string Mp3folder { get; set; }
        public string Destpath { get; set; }
        public string Schedule { get; set; }
        public string Options { get; set; }
        public string Hours { get; set; }
        public string Delfile { get; set; }
        public string Process { get; set; }
        public string Apppath { get; set; }
        public string Videofolder { get; set; }
        public string Monthlength { get; set; }
    }
}
