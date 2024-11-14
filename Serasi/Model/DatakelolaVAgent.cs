using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class DatakelolaVAgent
    {
        public decimal? Id { get; set; }
        public decimal UserId { get; set; }
        public string Username { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public decimal? CompanyId { get; set; }
        public decimal InHandled { get; set; }
        public DateTime? LastHandledAt { get; set; }
        public string Aux { get; set; }
    }
}
