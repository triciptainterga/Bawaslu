using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEBAPI_Bravo.Model
{
    public class BraNamaPerusahaan
    {
        public int Id { get; set; } // Primary Key
        public string AccountID { get; set; }
        public string PerusahaanID { get; set; }
        public string Nama_Perusahaan { get; set; }
        public string NPWP { get; set; }
        public string NomorTelepon { get; set; }
        public string Email { get; set; }
        public string Type { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
