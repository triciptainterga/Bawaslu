using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class TempBackupRestore
    {
        public int Id { get; set; }
        public string Idbackup { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public DateTime? DateCreate { get; set; }
        public string UserCreate { get; set; }
        public DateTime? DateUpdate { get; set; }
        public string UserUpdate { get; set; }
        public string DescriptionBackup { get; set; }
    }
}
