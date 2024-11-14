using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class TempEmailReasonCode
    {
        public int Id { get; set; }
        public string ReasonCodeId { get; set; }
        public string SubjectEmail { get; set; }
        public string BodyEmail { get; set; }
        public DateTime? DateCreate { get; set; }
        public string UserCreate { get; set; }
        public DateTime? DateUpdate { get; set; }
        public string UserUpdate { get; set; }
        public string Na { get; set; }
    }
}
