using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class SosmedGetHistoryDatum
    {
        public int? Id { get; set; }
        public string FlagData { get; set; }
        public string Messages { get; set; }
        public string HeaderId { get; set; }
        public string CommentId { get; set; }
        public string Username { get; set; }
        public string MediaType { get; set; }
        public string MediaUrl { get; set; }
        public string DateGetSosmed { get; set; }
    }
}
