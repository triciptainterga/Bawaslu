using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class V2UideskReleaseOutboundSubmitLog
    {
        public int Id { get; set; }
        public string TransaksiId { get; set; }
        public string TransaksiValue { get; set; }
        public string TransaksiType { get; set; }
        public string TransaksiTotal { get; set; }
        public string UserName { get; set; }
        public DateTime? DateCreate { get; set; }
    }
}
