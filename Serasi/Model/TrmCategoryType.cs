﻿using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class TrmCategoryType
    {
        public string Status { get; set; }
        public int Id { get; set; }
        public string CategoryId { get; set; }
        public string SubCategory1Id { get; set; }
        public string SubName { get; set; }
        public string Description { get; set; }
        public string Na { get; set; }
        public string UserCreate { get; set; }
        public DateTime? DateCreate { get; set; }
        public string UserUpdate { get; set; }
        public DateTime? DateUpdate { get; set; }
        public string CategoryName { get; set; }
    }
}
