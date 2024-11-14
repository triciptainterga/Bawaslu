using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class TempSettingSurvey
    {
        public int Id { get; set; }
        public string IconCsat { get; set; }
        public string UrlBke { get; set; }
        public string UrlInvision { get; set; }
        public string UrlEmoticon { get; set; }
        public string Type { get; set; }
        public int? TypeNumber { get; set; }
        public string UserCreate { get; set; }
        public DateTime? DateCreate { get; set; }
        public string HostUrlsurvey { get; set; }
    }
}
