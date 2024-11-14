using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class AppsUideskInteraction
    {
        public int Id { get; set; }
        public string TransaksiId { get; set; }
        public string Subject { get; set; }
        public string InteractionNote { get; set; }
        public string StatusTransaksi { get; set; }
        public string FollowState { get; set; }
        public string Files { get; set; }
        public string UserCreate { get; set; }
        public DateTime? DateCreate { get; set; }
    }
}
