using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class VtrxEmailTransaction
    {
        public decimal IvcId { get; set; }
        public string EmailId { get; set; }
        public string Direction { get; set; }
        public string Efrom { get; set; }
        public string Eto { get; set; }
        public string Ecc { get; set; }
        public string Ebcc { get; set; }
        public string Esubject { get; set; }
        public string EbodyText { get; set; }
        public string EbodyHtml { get; set; }
        public string Routed { get; set; }
        public string Handled { get; set; }
        public decimal? CustomerId { get; set; }
        public DateTime? EmailDate { get; set; }
        public string Path { get; set; }
        public string Reading { get; set; }
        public string Flag { get; set; }
        public string UserId { get; set; }
        public string Pic { get; set; }
        public string Pictujuan { get; set; }
        public string NumOfPages { get; set; }
        public string FaxStatus { get; set; }
        public string Ref { get; set; }
        public DateTime? Datereceive { get; set; }
        public string Ecc1 { get; set; }
        public DateTime? OriginalTime { get; set; }
        public string Agent { get; set; }
        public int Cnt { get; set; }
        public string TicketNumber { get; set; }
        public string JenisEmail { get; set; }
        public string GroupId { get; set; }
        public string CompId { get; set; }
        public string OrganizationId { get; set; }
        public string Account { get; set; }
        public string JenisEmailInternal { get; set; }
        public DateTime? Dateblending { get; set; }
        public string AttachmentIvcid { get; set; }
    }
}
