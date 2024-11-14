using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class TempPbxReportDaily
    {
        public string Username { get; set; }
        public string Uniqueid { get; set; }
        public string RecordingFile { get; set; }
        public string SourceCall { get; set; }
        public string Destination { get; set; }
        public string SourceContect { get; set; }
        public string StateCall { get; set; }
        public string PositionCall { get; set; }
        public DateTime? ChanStart { get; set; }
        public DateTime? Answer { get; set; }
        public DateTime? BridgeEnter { get; set; }
        public DateTime? BridgeExit { get; set; }
        public DateTime? Hangup { get; set; }
        public DateTime? ChanEnd { get; set; }
        public DateTime? LinkedidEnd { get; set; }
        public string RecordingFileOri { get; set; }
    }
}
