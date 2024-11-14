using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class InvLic
    {
        public int Id { get; set; }
        public string NameChannel { get; set; }
        public byte[] ValLic { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string FlagData { get; set; }
        public string SiteName { get; set; }
        public string ActiveLic { get; set; }
    }
}
