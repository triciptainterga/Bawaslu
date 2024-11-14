using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class UideskTrxEmailDetail
    {
        public int Id { get; set; }
        public string EmailId { get; set; }
        public string Url { get; set; }
        public string Filename { get; set; }
        public string Usercreate { get; set; }
        public DateTime? Datecreate { get; set; }
        public string Encode { get; set; }
        public string Filetype { get; set; }
        public string Direction { get; set; }
        public string Flag { get; set; }
        public DateTime? Dateupdate { get; set; }
        public string Ticketnumber { get; set; }
        public int? IvcId { get; set; }
        public string Filesize { get; set; }
        public string FlagEvent { get; set; }
        public string Forward { get; set; }
        public string Type { get; set; }
        public string EmbedName { get; set; }
    }
}
