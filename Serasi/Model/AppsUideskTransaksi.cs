using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class AppsUideskTransaksi
    {
        public int Id { get; set; }
        public string TransaksiId { get; set; }
        public string Subject { get; set; }
        public int? CompanyId { get; set; }
        public string CompanyName { get; set; }
        public int? PartnerId { get; set; }
        public string PartnerName { get; set; }
        public string PartnerCompany { get; set; }
        public int? ApplicationId { get; set; }
        public string ApplicationName { get; set; }
        public string FollowState { get; set; }
        public string StatusTransaksi { get; set; }
        public string PicUidesk { get; set; }
        public string InteractionNote { get; set; }
        public string Files { get; set; }
        public string UserCreate { get; set; }
        public DateTime? DateCreate { get; set; }
    }
}
