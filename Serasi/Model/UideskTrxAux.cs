using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class UideskTrxAux
    {
        public int Id { get; set; }
        public int? AuxId { get; set; }
        public string AuxDescription { get; set; }
        public string AuxUserName { get; set; }
        public DateTime? AuxDate { get; set; }
        public int? AuxState { get; set; }
        public DateTime? AuxEndDate { get; set; }
        public DateTime? AuxDateCreate { get; set; }
        public string AgentGroup { get; set; }
        public string AgentGroupName { get; set; }
        public string SiteId { get; set; }
        public string SiteName { get; set; }
    }
}
