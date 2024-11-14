using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class TUideskMultichatHeader
    {
        public string SessionId { get; set; }
        public string NoWa { get; set; }
        public string HandleName { get; set; }
        public string StatusChat { get; set; }
        public string NoteChat { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string ChannelName { get; set; }
        public string ChannelPagesName { get; set; }
        public string DurasiChat { get; set; }
        public string DateShort { get; set; }
        public string UserCreate { get; set; }
    }
}
