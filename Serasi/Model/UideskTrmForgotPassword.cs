using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class UideskTrmForgotPassword
    {
        public int Id { get; set; }
        public string EmailAddress { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? DateCreate { get; set; }
        public string Status { get; set; }
        public string Encrypt { get; set; }
    }
}
