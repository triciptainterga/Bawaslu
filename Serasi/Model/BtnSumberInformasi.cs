﻿using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class BtnSumberInformasi
    {
        public int Id { get; set; }
        public string SumberInformasi { get; set; }
        public string Usercreate { get; set; }
        public DateTime? Datecreate { get; set; }
        public string Userupdate { get; set; }
        public DateTime? Dateupdate { get; set; }
        public string Na { get; set; }
    }
}
