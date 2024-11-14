using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class UideskSmsBlast
    {
        public long Id { get; set; }
        public string Phonenumber { get; set; }
        public string Message { get; set; }
        public int Flag { get; set; }
        public int? Status { get; set; }
        public DateTime Createdate { get; set; }
        public DateTime Updatedate { get; set; }
        public string IdUpload { get; set; }
        public string CampaintName { get; set; }
        public DateTime? DateSchedule { get; set; }
        public string StatusId { get; set; }
    }
}
