using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class VHiStoryTransaction
    {
        public string DetailComplaint { get; set; }
        public string ResponComplaint { get; set; }
        public string CustomerId { get; set; }
        public string TicketNumber { get; set; }
        public string Name { get; set; }
        public string Hp { get; set; }
        public string Cif { get; set; }
        public string Nik { get; set; }
        public string Email { get; set; }
        public string AccountInbound { get; set; }
        public string Alamat { get; set; }
        public string SubCategory3Name { get; set; }
        public string Status { get; set; }
        public string TicketSourceName { get; set; }
        public string UserCreate { get; set; }
        public string NomorRekening { get; set; }
        public string DateCreate { get; set; }
        public string DateClose { get; set; }
        public string GenesysNumber { get; set; }
        public string ThreadId { get; set; }
        public string Account { get; set; }
        public string LastResponseBy { get; set; }
        public DateTime? LastResponseDate { get; set; }
        public string ParentNumberId { get; set; }
        public string ParentNumberCreated { get; set; }
        public DateTime? ParentNumberDate { get; set; }
        public string ParentReason { get; set; }
    }
}
