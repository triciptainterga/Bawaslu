using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class TempTrxCsatDetail
    {
        public int Id { get; set; }
        public string UniqueId { get; set; }
        public string ValueDetail { get; set; }
        public DateTime? DateCreate { get; set; }
    }
}
