using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEBAPI_Bravo.DinamicModel
{
    public class caseData
    {
      public string NamaKantor { get; set; }
    public string NamaKategory { get; set; }
    public string NamaSubCategory { get; set; }
    public Guid AccountId { get; set; }
    public Guid ContactId { get; set; }
    public string Origin { get; set; }
    public string Priority { get; set; }
    public string Judul { get; set; }
    public string NoTicket { get; set; }
    }
}


