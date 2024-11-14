using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class V2DatakelolaSocialmediaBucket
    {
        public int Id { get; set; }
        public string CommentId { get; set; }
        public string Jenis { get; set; }
        public string AgentId { get; set; }
        public string StatusData { get; set; }
        public DateTime? DateDistribusi { get; set; }
        public DateTime? DateHandle { get; set; }
        public DateTime? DateReply { get; set; }
        public DateTime? DateClose { get; set; }
    }
}
