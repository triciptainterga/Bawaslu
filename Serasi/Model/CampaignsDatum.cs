using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class CampaignsDatum
    {
        public int Id { get; set; }
        public int? IdgroupBlast { get; set; }
        public string GroupBlast { get; set; }
        public string Channel { get; set; }
        public string TypeChannel { get; set; }
        public string StatusBlast { get; set; }
        public string NoWa { get; set; }
        public string MsgBlast { get; set; }
        public string FileAttach { get; set; }
        public string Agent { get; set; }
        public string UserCreate { get; set; }
        public DateTime? DateCreate { get; set; }
        public string CallStatus { get; set; }
        public string CallDescription { get; set; }
    }
}
