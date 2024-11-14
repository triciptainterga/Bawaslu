using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class AppsUideskPartner
    {
        public int Id { get; set; }
        public string PartnerName { get; set; }
        public string PartnerCompany { get; set; }
        public string PartnerContactHp { get; set; }
        public string PartnerContactMail { get; set; }
        public string UserCreate { get; set; }
        public DateTime? DateCreate { get; set; }
    }
}
