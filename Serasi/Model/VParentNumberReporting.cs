using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class VParentNumberReporting
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
        public DateTime? ClosedDate { get; set; }
        public string StrPenyebab { get; set; }
        public string SkalaPrioritas { get; set; }
        public string JenisNasabah { get; set; }
        public string NomorRekening { get; set; }
        public string Email { get; set; }
        public string Hp { get; set; }
        public string CusStatus { get; set; }
        public string Alamat { get; set; }
        public string TicketSourceName { get; set; }
        public string GenesysId { get; set; }
        public string ThreadId { get; set; }
        public string Nik { get; set; }
        public string AccountInbound { get; set; }
        public string AccountId { get; set; }
        public string CreatedBy { get; set; }
        public string ClosedBy { get; set; }
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public int Sla { get; set; }
        public string UserSolved { get; set; }
        public string DateSolvedDisplay { get; set; }
        public string DateCreatedDisplay { get; set; }
        public string DateClosedDisplay { get; set; }
        public string ResponComplaint { get; set; }
        public DateTime? DateSolved { get; set; }
        public string TicketPosition { get; set; }
        public string Divisi { get; set; }
        public string ReleaseUser { get; set; }
        public string LastResponseBy { get; set; }
        public DateTime? LastResponseDate { get; set; }
        public string ExtendStatusId { get; set; }
        public string ExtendStatusSla { get; set; }
        public string ParentNumberId { get; set; }
        public string ParentChild { get; set; }
        public DateTime? ParentNumberDate { get; set; }
        public string ParentNumberCreated { get; set; }
        public string ParentReason { get; set; }
        public string Cif { get; set; }
    }
}
