using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class TempSurvey
    {
        public int Id { get; set; }
        public string UrlSurvey { get; set; }
        public string UniqueId { get; set; }
        public string TicketNumber { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public string DescSurvey { get; set; }
        public string HtmlSurvey { get; set; }
        public string DirectionSurvey { get; set; }
        public string ActiveSurvey { get; set; }
        public string UserCreate { get; set; }
        public DateTime? DateCreate { get; set; }
        public string UserUpdate { get; set; }
        public DateTime? DateUpdate { get; set; }
    }
}
