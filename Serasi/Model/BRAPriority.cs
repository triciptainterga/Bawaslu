using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEBAPI_Bravo.Model
{
    public class BRAPriority
    {
        public int Id { get; set; } 
        public string Name { get; set; } 
        public int? SLA { get; set; } 
        public string CreatedBy { get; set; } 
        public DateTime? CreatedDate { get; set; } 
    }
}
