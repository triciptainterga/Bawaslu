using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class AhuUideskTrmGreetingScript
    {
        public int Id { get; set; }
        public string Channel { get; set; }
        public string HeaderName { get; set; }
        public string GreetingScript { get; set; }
        public string UserCreate { get; set; }
        public string Na { get; set; }
        public DateTime? DateCreate { get; set; }
    }
}
