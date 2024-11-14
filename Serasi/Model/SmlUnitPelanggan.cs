using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class SmlUnitPelanggan
    {
        public int Id { get; set; }
        public string CustomerId { get; set; }
        public string NmCust { get; set; }
        public string UnitId { get; set; }
        public string UnitDesc { get; set; }
        public string SbuDesc { get; set; }
        public string ProjectDesc { get; set; }
        public string ClusterDesc { get; set; }
        public string RelationshipToUnit { get; set; }
        public DateTime? TgSerlah { get; set; }
        public DateTime? TglBast { get; set; }
        public DateTime? TglGaransi { get; set; }
        public string NoBast { get; set; }
        public DateTime? TglValidFinance { get; set; }
        public DateTime? TglValidTeknik { get; set; }
    }
}
