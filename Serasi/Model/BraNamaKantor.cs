using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEBAPI_Bravo.Model
{
    public class BraNamaKantor
    {
        public int Id { get; set; } 
        public string NamaKantor { get; set; } 
        public string Telepon { get; set; } 
        public string Email { get; set; } 
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; } 
        public string Alamat { get; set; } 
    }
}
