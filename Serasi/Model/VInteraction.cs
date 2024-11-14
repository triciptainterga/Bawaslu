using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class VInteraction
    {
        public string IdTabel { get; set; }
        public string TicketSourceName { get; set; }
        public string Nik { get; set; }
        public string AccountInbound { get; set; }
        public int Id { get; set; }
        public string TicketNumber { get; set; }
        public string GenesysId { get; set; }
        public string ThreadId { get; set; }
        public string ResponseComplaint { get; set; }
        public string Status { get; set; }
        public string Channel { get; set; }
        public string AgentCreate { get; set; }
        public DateTime? DateCreate { get; set; }
        public string FirstCreate { get; set; }
        public string DispatchTicket { get; set; }
        public string DispatchToLayer { get; set; }
        public string DispatchToDept { get; set; }
        public string DispatchToUserName { get; set; }
        public string Leveluser { get; set; }
        public string InteractionType { get; set; }
        public string ExtendStatusSla { get; set; }
        public string ExtendStatusId { get; set; }
        public string OrganizationName { get; set; }
        public string Tanggal { get; set; }
        public string Expr1 { get; set; }
        public string Cif { get; set; }
    }
}
