using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class CampaignsDataReminder
    {
        public int Id { get; set; }
        public int? CampaignDataId { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public string UserCreate { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? ReminderDate { get; set; }
        public string Account { get; set; }
        public string Channel { get; set; }
        public string StatusReminder { get; set; }
    }
}
