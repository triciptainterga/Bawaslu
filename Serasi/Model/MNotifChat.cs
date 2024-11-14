using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class MNotifChat
    {
        public int Id { get; set; }
        public string Notif { get; set; }
        public string Jenis { get; set; }
        public DateTime? Datecreate { get; set; }
        public string Usercreate { get; set; }
    }
}
