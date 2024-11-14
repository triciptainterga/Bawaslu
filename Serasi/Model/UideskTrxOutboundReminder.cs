using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class UideskTrxOutboundReminder
    {
        public int Id { get; set; }
        public int? CallOutboundId { get; set; }
        public string CallName { get; set; }
        public string CallEmail { get; set; }
        public string CallPhoneNumber { get; set; }
        public string CallPhoneOffice { get; set; }
        public string CallPhoneHome { get; set; }
        public string CallCustomerType { get; set; }
        public string CallProductCampaign { get; set; }
        public string CallPolisNumber { get; set; }
        public string CallStatus { get; set; }
        public string CallAgent { get; set; }
        public string CallUploadId { get; set; }
        public string CallSelesai { get; set; }
        public string CallReminderSubject { get; set; }
        public DateTime? CallReminderDate { get; set; }
        public string CallReminderStatus { get; set; }
        public string CallReminderDescription { get; set; }
    }
}
