using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class UserSettingChannel
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string MenuId { get; set; }
        public string SubMenuId { get; set; }
        public string SubMenuName { get; set; }
        public string DetailMenuName { get; set; }
        public string Url { get; set; }
        public string Status { get; set; }
        public string Param { get; set; }
        public string UserCreate { get; set; }
        public DateTime? DateCreate { get; set; }
    }
}
