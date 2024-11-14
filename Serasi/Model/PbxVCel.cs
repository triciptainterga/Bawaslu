using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class PbxVCel
    {
        public string Uniqueid { get; set; }
        public string Qstatsstatus { get; set; }
        public string RecordingFile { get; set; }
        public string SourceCall { get; set; }
        public string Destination { get; set; }
        public string SourceContect { get; set; }
        public string StateCall { get; set; }
        public string PositionCall { get; set; }
        public string ChanStart { get; set; }
        public string Answer { get; set; }
        public string BridgeEnter { get; set; }
        public string BridgeExit { get; set; }
        public string Hangup { get; set; }
        public string ChanEnd { get; set; }
        public string LinkedidEnd { get; set; }
    }
}
