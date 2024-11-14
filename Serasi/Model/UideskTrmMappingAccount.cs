using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class UideskTrmMappingAccount
    {
        public int Id { get; set; }
        public string UsernameUidesk { get; set; }
        public string UsernameThirdParty { get; set; }
        public string FlagChannel { get; set; }
        public string ProductChannel { get; set; }
        public string AccountNumber { get; set; }
        public string Status { get; set; }
        public string UserCreate { get; set; }
        public DateTime? DateCreate { get; set; }
    }
}
