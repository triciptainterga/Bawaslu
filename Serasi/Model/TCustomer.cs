using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class TCustomer
    {
        public int CustId { get; set; }
        public string Nama { get; set; }
        public string Alamat { get; set; }
        public string Email { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string SkillCase { get; set; }
        public string Pesan { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? LastDateCreate { get; set; }
        public string AlamatIp { get; set; }
        public string Subject { get; set; }
    }
}
