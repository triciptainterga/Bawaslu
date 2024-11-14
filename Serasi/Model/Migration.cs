using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class Migration
    {
        public int Id { get; set; }
        public string Migration1 { get; set; }
        public int Batch { get; set; }
    }
}
