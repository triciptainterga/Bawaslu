using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class MOrganization
    {
        public int OrganizationId { get; set; }
        public string Groupid { get; set; }
        public string Compid { get; set; }
        public string ChannelCode { get; set; }
        public string OrganizationName { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public string Usercreate { get; set; }
        public DateTime? Datecreate { get; set; }
        public string Userupdate { get; set; }
        public DateTime? Dateupdate { get; set; }
        public string Na { get; set; }
        public int? Flag { get; set; }
    }
}
