using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class TaurusMEksternal
    {
        public int Id { get; set; }
        public string TypeOfEksternal { get; set; }
        public string NameEksternal { get; set; }
        public string CompanyContact { get; set; }
        public string PicHp { get; set; }
        public string CompanyEmail { get; set; }
        public string Wa { get; set; }
        public string UserCreate { get; set; }
        public DateTime? DateCreate { get; set; }
        public string UserUpdate { get; set; }
        public DateTime? DateUpdate { get; set; }
        public string Na { get; set; }
        public string CompanyAddress { get; set; }
    }
}
