using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class UideskFoto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string UserCreate { get; set; }
        public DateTime? DateCreate { get; set; }
    }
}
