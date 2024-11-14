using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class CtiGetWebhuk
    {
        public int Id { get; set; }
        public string TxtGetWebhuk { get; set; }
        public DateTime? DateGetData { get; set; }
        public string CallId { get; set; }
        public string Callee { get; set; }
        public string Caller { get; set; }
        public string CallerDisplayName { get; set; }
        public string CdrId { get; set; }
        public string Direction { get; set; }
        public string EventType { get; set; }
        public string RequestId { get; set; }
        public string SessionId { get; set; }
        public string TenantId { get; set; }
        public string TenantName { get; set; }
        public string Time { get; set; }
    }
}
