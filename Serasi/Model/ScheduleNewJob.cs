using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class ScheduleNewJob
    {
        public int Id { get; set; }
        public string JobName { get; set; }
        public string CronExpression { get; set; }
        public bool IsActive { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
