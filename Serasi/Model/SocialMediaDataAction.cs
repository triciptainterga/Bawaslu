using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class SocialMediaDataAction
    {
        public int Id { get; set; }
        public string Socmed { get; set; }
        public string SocmedSource { get; set; }
        public string SocmedSourceDetail { get; set; }
        public string SocmedActionDo { get; set; }
        public string SocmedId { get; set; }
        public DateTime? DateAction { get; set; }
        public string DescAction { get; set; }
        public string UserCreate { get; set; }
        public string UserUpdate { get; set; }
        public DateTime? DateUpdate { get; set; }
        public string Active { get; set; }
    }
}
