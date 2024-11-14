using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class MsLevelUser
    {
        public int LevelUserId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Na { get; set; }
        public string EscalationIdentity { get; set; }
        public string RoleDescription { get; set; }
    }
}
