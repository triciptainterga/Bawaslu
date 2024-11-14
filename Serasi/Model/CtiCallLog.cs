using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class CtiCallLog
    {
        public string Id { get; set; }
        public DateTime? Startcall { get; set; }
        public DateTime? Endcall { get; set; }
        public string Agent { get; set; }
        public string Phoneno { get; set; }
        public string Callid { get; set; }
        public string Duration { get; set; }
        public string Ext { get; set; }
        public string Calltype { get; set; }
        public string Statuscall { get; set; }
        public string Customerid { get; set; }
        public string Ticketid { get; set; }
    }
}
