﻿using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class IccGroupCorporate
    {
        public int Id { get; set; }
        public string GroupCorporate { get; set; }
        public string UserCreate { get; set; }
        public DateTime? DateCreate { get; set; }
    }
}