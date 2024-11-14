using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class TempRSla
    {
        public long? No { get; set; }
        public string TicketNumber { get; set; }
        public string ChannelCode { get; set; }
        public string CategoryName { get; set; }
        public string Level1 { get; set; }
        public string Level2 { get; set; }
        public string Level3 { get; set; }
        public string Description { get; set; }
        public string TicketStatus { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UserSolved { get; set; }
        public string DateSolvedDisplay { get; set; }
        public DateTime? ClosedDate { get; set; }
        public string ClosedBy { get; set; }
        public int Sla { get; set; }
        public string GenesysId { get; set; }
        public string ThreadId { get; set; }
        public string Nik { get; set; }
        public string AccountInbound { get; set; }
        public string AccountId { get; set; }
        public int? OverSlareal { get; set; }
        public int? UsedDaySla { get; set; }
        public string WithinSla { get; set; }
        public string CustomerName { get; set; }
        public string CustomerUnit { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateClose { get; set; }
        public DateTime? DateSolved { get; set; }
        public string UsedDaySlaok { get; set; }
    }
}
