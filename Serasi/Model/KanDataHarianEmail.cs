using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class KanDataHarianEmail
    {
        public int Id { get; set; }
        public string AgentName { get; set; }
        public string ProductId { get; set; }
        public string ProductCampaign { get; set; }
        public string MaxHandle { get; set; }
        public string NowHandle { get; set; }
        public string NowHandleToday { get; set; }
        public DateTime? DateCreate { get; set; }
    }
}
