using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class DatakelolaUserProfile
    {
        public decimal? Id { get; set; }
        public string ProfileId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Photo { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
