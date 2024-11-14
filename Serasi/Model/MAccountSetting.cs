using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class MAccountSetting
    {
        public int Id { get; set; }
        public string AccountName { get; set; }
        public string AccountPassword { get; set; }
        public string Smtp { get; set; }
        public string Port { get; set; }
        public string Type { get; set; }
        public string DateInsert { get; set; }
        public string UserCreate { get; set; }
    }
}
