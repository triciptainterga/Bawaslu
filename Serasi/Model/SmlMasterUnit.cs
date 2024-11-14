using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class SmlMasterUnit
    {
        public string Unitid { get; set; }
        public string Unitdesc { get; set; }
        public string NoBast { get; set; }
        public string TglBast { get; set; }
        public string TglGaransi { get; set; }
        public string TgSerah { get; set; }
        public string NmCust { get; set; }
        public string NoHp { get; set; }
        public string AlamatSurat { get; set; }
        public string NoKtp { get; set; }
        public string Email { get; set; }
        public string TglValidFinance { get; set; }
        public string TglValidTeknik { get; set; }
    }
}
