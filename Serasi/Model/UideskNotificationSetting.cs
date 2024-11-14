using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class UideskNotificationSetting
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public string Usercreate { get; set; }
        public DateTime? Datecreate { get; set; }
        public string Category { get; set; }
    }
}
