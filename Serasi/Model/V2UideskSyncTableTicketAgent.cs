using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class V2UideskSyncTableTicketAgent
    {
        public int Id { get; set; }
        public string SyncUserName { get; set; }
        public string SyncName { get; set; }
        public string SyncGroup { get; set; }
        public string SyncSite { get; set; }
        public string SyncStatus { get; set; }
        public string SyncData { get; set; }
        public string SyncStatusThread { get; set; }
        public string SyncDataThread { get; set; }
        public string SyncCreatedBy { get; set; }
        public DateTime? SyncDateCreated { get; set; }
    }
}
