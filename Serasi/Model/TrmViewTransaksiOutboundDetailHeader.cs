using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class TrmViewTransaksiOutboundDetailHeader
    {
        public int Id { get; set; }
        public int? CallOutboundId { get; set; }
        public string CallPolisNumber { get; set; }
        public string CallName { get; set; }
        public string CallPhoneNumber { get; set; }
        public string CallReasonDetail { get; set; }
        public string CallDescriptionDetail { get; set; }
        public string CallStatus { get; set; }
        public string CallAgent { get; set; }
        public DateTime? CallDate { get; set; }
        public string CallReason { get; set; }
        public string CallEmail { get; set; }
        public string CallCustomerType { get; set; }
        public string CallTicketNumber { get; set; }
        public string CallTicketStatus { get; set; }
        public string CallJenisKelamin { get; set; }
    }
}
