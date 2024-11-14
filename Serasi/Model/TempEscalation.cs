using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class TempEscalation
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public string WorkflowName { get; set; }
        public string FlowChart { get; set; }
        public int? TicketPosition { get; set; }
        public string FlowType { get; set; }
        public DateTime? DateCreate { get; set; }
    }
}
