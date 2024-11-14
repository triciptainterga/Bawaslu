using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class QiscusTicketDetail
    {
        public long Id { get; set; }
        public long QiscusTicketHeaderId { get; set; }
        public long QiscusTicketParticipantId { get; set; }
        public string MessageType { get; set; }
        public string Message { get; set; }
        public DateTime QiscusTimestamp { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
