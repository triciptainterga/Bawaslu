using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class TrmEpicUser
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Pin { get; set; }
        public int Role { get; set; }
        public int Type { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public string PbxUser { get; set; }
        public string PbxPassword { get; set; }
        public int? EpicLogin { get; set; }
        public DateTime? LoginDate { get; set; }
    }
}
