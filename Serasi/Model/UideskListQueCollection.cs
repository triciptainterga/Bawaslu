using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class UideskListQueCollection
    {
        public int Id { get; set; }
        public DateTime? DateQue { get; set; }
        public DateTime? DateDistribution { get; set; }
        public string DataIdnumber { get; set; }
        public string ProductId { get; set; }
        public string Channel { get; set; }
        public string DescriptionQue { get; set; }
        public string Na { get; set; }
    }
}
