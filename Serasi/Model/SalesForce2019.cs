using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class SalesForce2019
    {
        public int Id { get; set; }
        public string AccountName { get; set; }
        public string CaseOwner { get; set; }
        public string ContactName { get; set; }
        public string Mobile { get; set; }
        public string Kota { get; set; }
        public string Karyawan { get; set; }
        public string Subject { get; set; }
        public string Status { get; set; }
        public string CaseNumber { get; set; }
        public string SubType1 { get; set; }
        public string SubType2 { get; set; }
        public string SubType3 { get; set; }
        public string SubType4 { get; set; }
        public string CaseOrigin { get; set; }
        public DateTime? DateCreate { get; set; }
    }
}
