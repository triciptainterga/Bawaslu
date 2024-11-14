using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class MSession
    {
        public int Id { get; set; }
        public string SessionTime { get; set; }
        public string Status { get; set; }
    }
}
