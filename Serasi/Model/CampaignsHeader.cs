using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class CampaignsHeader
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }
        public string CampaignDescription { get; set; }
        public string CampaignImage { get; set; }
        public string Channel { get; set; }
        public string StatusActive { get; set; }
        public DateTime? DateCreate { get; set; }
        public string UserCreate { get; set; }
    }
}
