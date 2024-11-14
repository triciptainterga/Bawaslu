using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class VwCampaignsDatum
    {
        public string CustId { get; set; }
        public string CustName { get; set; }
        public int? Idcampaigns { get; set; }
        public string GroupBlast { get; set; }
        public string StatusBlast { get; set; }
        public string NoWa { get; set; }
        public string MsgBlast { get; set; }
        public string FileAttach { get; set; }
    }
}
