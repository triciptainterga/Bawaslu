using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class DatakelolaVAgenthandle
    {
        public decimal? Id { get; set; }
        public string Type { get; set; }
        public decimal UserId { get; set; }
        public string Username { get; set; }
        public decimal? InHandled { get; set; }
        public string Aux { get; set; }
        public int MaxHandle { get; set; }
        public decimal? CompanyId { get; set; }
        public decimal SourceId { get; set; }
    }
}
