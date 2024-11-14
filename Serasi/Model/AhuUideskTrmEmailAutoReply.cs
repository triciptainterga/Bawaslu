using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class AhuUideskTrmEmailAutoReply
    {
        public int Id { get; set; }
        public string TemplateReply { get; set; }
        public string Account { get; set; }
        public string State { get; set; }
        public string UserCreate { get; set; }
        public DateTime? DateCreate { get; set; }
    }
}
