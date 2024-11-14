using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class TrmCustomerChannel
    {
        public string StatusNya { get; set; }
        public string StatusColor { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
        public string ValueChannel { get; set; }
        public string FlagChannel { get; set; }
        public string CustomerId { get; set; }
        public string UserCreate { get; set; }
        public DateTime? DateCreate { get; set; }
        public string AgentName { get; set; }
    }
}
