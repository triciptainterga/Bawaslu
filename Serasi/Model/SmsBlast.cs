using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class SmsBlast
    {
        public int Id { get; set; }
        public string Phonenumber { get; set; }
        public string Message { get; set; }
        public string IdUpload { get; set; }
        public int Flag { get; set; }
        public string Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
    }
}
