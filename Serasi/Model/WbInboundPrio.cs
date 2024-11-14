using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class WbInboundPrio
    {
        public int Id { get; set; }
        public string Idcms { get; set; }
        public string AgentName { get; set; }
        public string LoginId { get; set; }
        public string Extension { get; set; }
        public string AuxReason { get; set; }
        public string StateNya { get; set; }
        public string EmptyNya { get; set; }
        public string TimeNya { get; set; }
        public string Na { get; set; }
    }
}
