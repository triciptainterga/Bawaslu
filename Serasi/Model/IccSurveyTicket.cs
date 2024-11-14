using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class IccSurveyTicket
    {
        public int Id { get; set; }
        public int? RateSurvey { get; set; }
        public string TicketNumber { get; set; }
        public string DescriptionText { get; set; }
        public string UserCreate { get; set; }
        public DateTime? DateCreate { get; set; }
        public string UserUpdate { get; set; }
        public DateTime? DateUpdate { get; set; }
        public string Na { get; set; }
    }
}
