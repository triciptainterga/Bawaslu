using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class TeleTrxTask
    {
        public int Id { get; set; }
        public string HeaderId { get; set; }
        public string NamaTask { get; set; }
        public string DetailTask { get; set; }
        public string NextTask { get; set; }
        public string Kategori { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
        public string Reminder { get; set; }
        public DateTime? DueDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? DateCreate { get; set; }
    }
}
