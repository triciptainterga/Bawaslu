using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class VwWrittenVerbal
    {
        public long? RowNum { get; set; }
        public string TicketNumber { get; set; }
        public string UserCreate { get; set; }
        public string NameExtend { get; set; }
        public DateTime? DateCreate { get; set; }
        public int SlaSub3 { get; set; }
        public int? SlaExtend { get; set; }
        public int? SlaLogic { get; set; }
        public int? RunningSla { get; set; }
        public string Logic { get; set; }
    }
}
