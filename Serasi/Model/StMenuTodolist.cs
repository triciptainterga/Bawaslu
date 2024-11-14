using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class StMenuTodolist
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public int? Day { get; set; }
        public DateTime? FilterDinamis { get; set; }
        public string Usercreate { get; set; }
        public DateTime? Datecreate { get; set; }
    }
}
