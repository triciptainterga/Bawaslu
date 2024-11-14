using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class AppsUideskCompany
    {
        public int Id { get; set; }
        public string Company { get; set; }
        public string PicName { get; set; }
        public string PicContactHp { get; set; }
        public string PicContactMail { get; set; }
        public string UserCreate { get; set; }
        public DateTime? DateCreate { get; set; }
    }
}
