using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class TrmDataBucket
    {
        public int? CallerId { get; set; }
        public string CallPhoneNumber { get; set; }
        public string CallName { get; set; }
        public string CallPolisNumber { get; set; }
        public string CallEmail { get; set; }
        public DateTime? CallCreatedDate { get; set; }
        public string CallReason { get; set; }
        public int Id { get; set; }
        public DateTime? DateQue { get; set; }
        public DateTime? DateDistribution { get; set; }
        public string DataIdnumber { get; set; }
        public int? ProductId { get; set; }
        public string Channel { get; set; }
        public string DescriptionQue { get; set; }
        public string Na { get; set; }
    }
}
