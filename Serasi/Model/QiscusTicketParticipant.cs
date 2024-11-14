using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class QiscusTicketParticipant
    {
        public long Id { get; set; }
        public long QiscusTicketHeaderId { get; set; }
        public string UserType { get; set; }
        public long UserId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
