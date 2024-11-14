using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class FeatureCustomRoleuser
    {
        public int Id { get; set; }
        public string LevelUser { get; set; }
        public string UserId { get; set; }
        public string GroupAgent { get; set; }
        public string DivisiCode { get; set; }
        public DateTime? DateCreate { get; set; }
    }
}
