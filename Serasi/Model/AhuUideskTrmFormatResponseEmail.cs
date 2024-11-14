using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class AhuUideskTrmFormatResponseEmail
    {
        public int Id { get; set; }
        public string TemplateResponse { get; set; }
        public string Format { get; set; }
        public string State { get; set; }
        public string UserCreate { get; set; }
        public DateTime? DateCreate { get; set; }
    }
}
