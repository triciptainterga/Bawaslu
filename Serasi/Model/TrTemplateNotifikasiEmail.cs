using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class TrTemplateNotifikasiEmail
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string Type { get; set; }
        public string UserCreate { get; set; }
        public DateTime? DateCreate { get; set; }
        public string HeaderHtml { get; set; }
        public string BodyHtml { get; set; }
        public string FooterHtml { get; set; }
        public string HtmlTest { get; set; }
    }
}
