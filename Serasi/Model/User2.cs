using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class User2
    {
        public int SubMenuId { get; set; }
        public int? MenuId { get; set; }
        public string SubMenuName { get; set; }
        public string Url { get; set; }
        public string DivId { get; set; }
        public string Icon { get; set; }
        public string Param { get; set; }
        public string Activity { get; set; }
    }
}
