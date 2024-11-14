using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class _4ReportEmail
    {
        public string IvcId { get; set; }
        public string EmailId { get; set; }
        public string Direction { get; set; }
        public string Efrom { get; set; }
        public string Eto { get; set; }
        public string Esubject { get; set; }
        public string EbodyHtml { get; set; }
        public DateTime? EmailDate { get; set; }
        public string Datereceive { get; set; }
        public string TicketNumber { get; set; }
        public string JenisEmail { get; set; }
        public string Agent { get; set; }
        public string RefId { get; set; }
        public string Username { get; set; }
    }
}
