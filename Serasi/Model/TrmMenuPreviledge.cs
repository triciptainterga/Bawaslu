using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class TrmMenuPreviledge
    {
        public string Userid { get; set; }
        public int? MenuId { get; set; }
        public string MenuName { get; set; }
        public string UrlUser1 { get; set; }
        public string SubMenuId { get; set; }
        public string UrlUser2 { get; set; }
        public string SubMenuName { get; set; }
        public string MenuIdtree { get; set; }
        public string MenuTreeName { get; set; }
        public string UrlUser3 { get; set; }
    }
}
