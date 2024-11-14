using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class CampaignsDataDetail
    {
        public int Id { get; set; }
        public int? CampaignDataId { get; set; }
        public string PriorityScale { get; set; }
        public string CallbackReminder { get; set; }
        public string CallStatus { get; set; }
        public string Description { get; set; }
        public string UserCreate { get; set; }
        public DateTime? DateCreate { get; set; }
        public string RecordingFile { get; set; }
    }
}
