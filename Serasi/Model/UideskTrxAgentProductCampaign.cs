using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class UideskTrxAgentProductCampaign
    {
        public int Id { get; set; }
        public int? Channelid { get; set; }
        public string ChannelName { get; set; }
        public int? AgentId { get; set; }
        public string AgentName { get; set; }
        public string ProductId { get; set; }
        public string ProductCampaign { get; set; }
        public int? Maxhandle { get; set; }
        public int? Nowhandle { get; set; }
        public string Createdby { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? Login { get; set; }
        public int? AuxId { get; set; }
        public int? Proces { get; set; }
        public int? NowHandleToday { get; set; }
    }
}
