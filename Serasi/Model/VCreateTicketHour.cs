using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class VCreateTicketHour
    {
        public string JamNya { get; set; }
        public string CategoryName { get; set; }
        public int? TotNya { get; set; }
        public string UserCreate { get; set; }
        public int? IdGrup { get; set; }
        public string Divisi { get; set; }
        public string TicketPosition { get; set; }
    }
}
