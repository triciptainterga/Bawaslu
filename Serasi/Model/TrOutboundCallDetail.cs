﻿using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class TrOutboundCallDetail
    {
        public int Id { get; set; }
        public string HeaderId { get; set; }
        public string TicketNumber { get; set; }
        public string Reason { get; set; }
        public string Status { get; set; }
        public string Ucreated { get; set; }
        public DateTime? Dcreated { get; set; }
    }
}