using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class CollTrxReport
    {
        public int Id { get; set; }
        public string CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Telepon { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Gender { get; set; }
        public string JobTitle { get; set; }
        public string Status { get; set; }
        public string Agent { get; set; }
        public string Address { get; set; }
        public string Negara { get; set; }
        public string Provinsi { get; set; }
        public string Kota { get; set; }
        public string KodePos { get; set; }
        public string Call { get; set; }
        public string CallReason { get; set; }
        public string CallSelesai { get; set; }
        public DateTime? DateCreate { get; set; }
        public string ProdukId { get; set; }
        public string ProdukCampaign { get; set; }
        public string TypePinjaman { get; set; }
        public string NamaPinjaman { get; set; }
        public decimal? TotalPinjaman { get; set; }
        public decimal? JumlahTagihan { get; set; }
        public string PeriodeFrom { get; set; }
        public string PeriodeTo { get; set; }
        public string PeriodePinjaman { get; set; }
        public DateTime? JatuhTempo { get; set; }
        public string UploadId { get; set; }
        public string UploadBy { get; set; }
        public string UploadStatus { get; set; }
        public string CountingCall { get; set; }
        public DateTime? DistributionDate { get; set; }
        public string DistributionBy { get; set; }
        public string Keterangan { get; set; }
        public string StatusTagihan { get; set; }
        public string StatusTelepon { get; set; }
        public string UserName { get; set; }
        public DateTime? DateReport { get; set; }
    }
}
