using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class OutTrxDetail
    {
        public int Id { get; set; }
        public string HeaderId { get; set; }
        public string Name { get; set; }
        public string Telepon { get; set; }
        public string Keterangan { get; set; }
        public string StatusTelepon { get; set; }
        public string StatusData { get; set; }
        public DateTime? Tanggal { get; set; }
        public string EskalasiTicket { get; set; }
        public string UploadId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateCreate { get; set; }
    }
}
