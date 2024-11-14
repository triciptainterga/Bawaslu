using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class TDispatch
    {
        public int TDispatchId { get; set; }
        public string TicketNumber { get; set; }
        public DateTime? DateDispatch { get; set; }
        public DateTime? DateDispatchPic { get; set; }
        public DateTime? DateFeedBackPictoCu { get; set; }
        public string UserDispatch { get; set; }
        public string UserDispatchPic { get; set; }
        public string UserReAssignPictoCu { get; set; }
        public string StatusDispatch { get; set; }
        public string AlasanDispatch { get; set; }
        public string AlasanDispatchPic { get; set; }
        public string GoToLeader { get; set; }
        public string ReAssign { get; set; }
        public string OverSla { get; set; }
        public DateTime? DateOverSla { get; set; }
        public string Na { get; set; }
    }
}
