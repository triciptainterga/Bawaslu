using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class SmlImageLogin
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Status { get; set; }
        public string UserCreate { get; set; }
        public DateTime? DateCreate { get; set; }
    }
}
