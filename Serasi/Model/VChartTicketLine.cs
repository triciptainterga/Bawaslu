using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class VChartTicketLine
    {
        public string JamNya { get; set; }
        public string UserCreate { get; set; }
        public int Complaint { get; set; }
        public int Feedback { get; set; }
        public int Information { get; set; }
        public int Request { get; set; }
        public int SecurityOther { get; set; }
    }
}
