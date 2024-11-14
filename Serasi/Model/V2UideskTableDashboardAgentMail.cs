using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class V2UideskTableDashboardAgentMail
    {
        public int Id { get; set; }
        public string Agent { get; set; }
        public string EmailReceived { get; set; }
        public string EmailResponse { get; set; }
        public string EmailNotResponse { get; set; }
        public string EmailQiwing { get; set; }
        public string UserName { get; set; }
        public DateTime? DateCreate { get; set; }
    }
}
