using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class UideskOfficeHour
    {
        public int Id { get; set; }
        public string TypeHour { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }
        public string Na { get; set; }
    }
}
