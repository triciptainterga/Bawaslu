using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class BtnTrxAttchment
    {
        public int Id { get; set; }
        public string TicketNumber { get; set; }
        public string Filename { get; set; }
        public string Path { get; set; }
        public string Usercreate { get; set; }
        public DateTime? Datecreate { get; set; }
        public string GenesysNumber { get; set; }
        public string CusTomerId { get; set; }
        public string FlagTrx { get; set; }
        public string FolderName { get; set; }
    }
}
