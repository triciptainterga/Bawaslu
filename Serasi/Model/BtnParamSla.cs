using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class BtnParamSla
    {
        public int Id { get; set; }
        public int? JumlahSla { get; set; }
        public string WarnaSla { get; set; }
        public string KeteranganSla { get; set; }
        public string Na { get; set; }
        public string Usercreate { get; set; }
        public DateTime? Datecreate { get; set; }
        public string Userupdate { get; set; }
        public DateTime? Dateupdate { get; set; }
    }
}
