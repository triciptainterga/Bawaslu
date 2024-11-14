using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class CampaignsHeaderDetail
    {
        public int Id { get; set; }
        public string HeaderId { get; set; }
        public string DetailName { get; set; }
        public string DetailDescription { get; set; }
        public string Status { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateCreate { get; set; }
        public string TypeCall { get; set; }
        public string LogicData { get; set; }
    }
}
