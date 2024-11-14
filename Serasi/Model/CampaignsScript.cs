using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class CampaignsScript
    {
        public int Id { get; set; }
        public string DetailId { get; set; }
        public string CampaignScript { get; set; }
        public string CampaignDescription { get; set; }
        public string Channel { get; set; }
        public string StatusActive { get; set; }
        public string UserCreate { get; set; }
        public DateTime? DateCreate { get; set; }
        public string CampaignScriptHeader { get; set; }
        public string CampaignScriptFooter { get; set; }
    }
}
