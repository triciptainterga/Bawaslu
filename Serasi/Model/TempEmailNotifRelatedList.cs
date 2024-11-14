using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class TempEmailNotifRelatedList
    {
        public int Id { get; set; }
        public string IdemailNotif { get; set; }
        public string IdemailNotifKategori { get; set; }
        public string IdemailRelated { get; set; }
        public string JenisList { get; set; }
        public string LayerId { get; set; }
        public string UnitCaseId { get; set; }
        public string EmailAddress { get; set; }
        public string Na { get; set; }
        public string UserCreate { get; set; }
        public DateTime? DateCreate { get; set; }
        public string UserUpdate { get; set; }
        public DateTime? DateUpdate { get; set; }
    }
}
