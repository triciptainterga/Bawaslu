﻿using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class User4
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int? MenuId { get; set; }
        public string SubMenuId { get; set; }
        public string MenuIdtree { get; set; }
        public string LevelUserId { get; set; }
        public string UserCreate { get; set; }
        public DateTime? DateCreate { get; set; }
        public string Description { get; set; }
        public string Access { get; set; }
    }
}
