using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class UideskTrmSosialMedium
    {
        public int Id { get; set; }
        public string AccountName { get; set; }
        public string AccountPassword { get; set; }
        public string AccountType { get; set; }
        public string AccountStatus { get; set; }
        public string AccountCreate { get; set; }
        public DateTime? AccountDate { get; set; }
    }
}
