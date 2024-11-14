using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class TempLogNewHelpdesk
    {
        public int Id { get; set; }
        public string TicketNumber { get; set; }
        public string LogType { get; set; }
        public DateTime? DateCreate { get; set; }
        public string DescriptionLog { get; set; }
    }
}
