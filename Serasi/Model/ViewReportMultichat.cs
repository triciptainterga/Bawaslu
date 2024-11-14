using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class ViewReportMultichat
    {
        public string ChatId { get; set; }
        public string ChatType { get; set; }
        public string RecipientName { get; set; }
        public string SenderName { get; set; }
        public string Messages { get; set; }
        public DateTime? DateCreate { get; set; }
        public string SosmedAgent { get; set; }
    }
}
