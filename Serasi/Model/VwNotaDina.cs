using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class VwNotaDina
    {
        public int Id { get; set; }
        public string TicketNumber { get; set; }
        public string NomorNota { get; set; }
        public DateTime? TanggalNota { get; set; }
        public string JudulNota { get; set; }
        public string PenerimaNota { get; set; }
        public string SalinanDistribusi { get; set; }
        public string PerihalNota { get; set; }
        public string IsiPesan { get; set; }
        public string LampiranNota { get; set; }
        public string LastNotaPosition { get; set; }
        public string StatusNota { get; set; }
        public string UserCreate { get; set; }
        public DateTime? DateCreate { get; set; }
        public int? Expr1 { get; set; }
        public string Expr2 { get; set; }
        public string Username { get; set; }
        public string UserPosition { get; set; }
        public DateTime? DatePosition { get; set; }
        public string StatusDisposition { get; set; }
        public DateTime? DateDisposition { get; set; }
        public string Expr3 { get; set; }
        public string Keterangan { get; set; }
    }
}
