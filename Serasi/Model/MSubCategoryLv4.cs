using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class MSubCategoryLv4
    {
        public int Id { get; set; }
        public string CustomerId { get; set; }
        public string Idkamus { get; set; }
        public string CategoryId { get; set; }
        public string SubCategory1Id { get; set; }
        public string SubCategory2Id { get; set; }
        public string SubCategory3Id { get; set; }
        public string SubCategory4Id { get; set; }
        public string SubName { get; set; }
        public string Description { get; set; }
        public string TujuanEskalasi { get; set; }
        public string Priority { get; set; }
        public string Severity { get; set; }
        public string Na { get; set; }
        public int? Sla { get; set; }
        public string ReasonCode { get; set; }
        public string ResponseAgent { get; set; }
        public string StatusCustomer { get; set; }
        public string Version { get; set; }
        public DateTime? ContractStartdate { get; set; }
        public DateTime? ContractEnddate { get; set; }
        public string License { get; set; }
        public string UserCreate { get; set; }
        public DateTime? DateCreate { get; set; }
        public string UserUpdate { get; set; }
        public DateTime? DateUpdate { get; set; }
        public string Layer { get; set; }
    }
}
