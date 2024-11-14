using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class IccAssignEmailHistory
    {
        public string IvcId { get; set; }
        public string Channelid { get; set; }
        public DateTime? Dated { get; set; }
        public string Agent { get; set; }
        public string Note { get; set; }
        public DateTime? Datecreate { get; set; }
    }
}
