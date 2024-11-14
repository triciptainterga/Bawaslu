using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class TempSettingParameter
    {
        public int Id { get; set; }
        public int? PhoneLength { get; set; }
        public int? AcountNumberLength { get; set; }
        public int? Ciflength { get; set; }
        public int? Niklength { get; set; }
        public string PathHtml { get; set; }
        public string UploadDirectoryAttachment { get; set; }
        public string ViewDirectoryAttachment { get; set; }
        public DateTime? DateCreate { get; set; }
    }
}
