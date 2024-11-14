using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class CdrGetWebhuk
    {
        public int Id { get; set; }
        public string TxtGetWebhuk { get; set; }
        public DateTime? DateGetData { get; set; }
        public string AnsweredTime { get; set; }
        public string CallId { get; set; }
        public string CallStatus { get; set; }
        public string CallTargets { get; set; }
        public string Callee { get; set; }
        public string CalleeDomain { get; set; }
        public string Caller { get; set; }
        public string CallerDisplayName { get; set; }
        public string CallerDomain { get; set; }
        public string DidCid { get; set; }
        public string Direction { get; set; }
        public string EndedReason { get; set; }
        public string EndedTime { get; set; }
        public string EventType { get; set; }
        public string FailCode { get; set; }
        public string FinalDest { get; set; }
        public string OutboundCallerId { get; set; }
        public string RecordingFile { get; set; }
        public string RequestDescription { get; set; }
        public string RequestId { get; set; }
        public string RingDuration { get; set; }
        public string RingTime { get; set; }
        public string SessionId { get; set; }
        public string StartTime { get; set; }
        public string TalkDuration { get; set; }
        public string TenantId { get; set; }
        public string TenantName { get; set; }
    }
}
