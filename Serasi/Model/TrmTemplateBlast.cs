﻿using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class TrmTemplateBlast
    {
        public string MsgBlastSubstring { get; set; }
        public string MsgBlastContent { get; set; }
        public int Id { get; set; }
        public string UserCreate { get; set; }
        public DateTime? DateCreate { get; set; }
        public string TemplateName { get; set; }
        public string MsgBlast { get; set; }
        public string UrlAttcach { get; set; }
        public string StatusMsg { get; set; }
    }
}
