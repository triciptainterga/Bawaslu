using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class Job
    {
        public int JobId { get; set; }
        public string JobName { get; set; }
        public string JobDescription { get; set; }
        public string JobType { get; set; }
        public string Status { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
