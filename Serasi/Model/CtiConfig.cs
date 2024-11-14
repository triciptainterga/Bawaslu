using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class CtiConfig
    {
        public int Id { get; set; }
        public string Aes { get; set; }
        public string AesUser { get; set; }
        public string AesPassword { get; set; }
        public string Port { get; set; }
        public string IPdb { get; set; }
        public string DbUser { get; set; }
        public string DbPassword { get; set; }
        public string DbName { get; set; }
        public string DialCode { get; set; }
        public string CallHistoryEndpoint { get; set; }
        public string AgentEndpoint { get; set; }
        public string InboundEndpoint { get; set; }
        public string OutboundEndpoint { get; set; }
        public string BrowserPath { get; set; }
        public string Theme { get; set; }
        public int? Acw { get; set; }
        public string PbxLogin { get; set; }
        public string PbxLogOut { get; set; }
        public string PbxAux { get; set; }
        public string PbxAutoIn { get; set; }
    }
}
