using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class TrmLoginAgentOutbound
    {
        public string EmailAddress { get; set; }
        public bool? Outbound { get; set; }
        public int? Login { get; set; }
        public string IdAux { get; set; }
        public int? Id { get; set; }
        public int? Channelid { get; set; }
        public string AgentName { get; set; }
        public int? ProductId { get; set; }
        public string ProductCampaign { get; set; }
        public int? Maxhandle { get; set; }
        public int? Nowhandle { get; set; }
        public string Createdby { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
