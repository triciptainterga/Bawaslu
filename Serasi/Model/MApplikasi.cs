using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class MApplikasi
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string EmailAddress { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Ticket { get; set; }
        public string Email { get; set; }
        public string Twitter { get; set; }
        public string Facebook { get; set; }
        public string Fax { get; set; }
        public string Chat { get; set; }
        public string Sms { get; set; }
        public string Telegram { get; set; }
        public string Instagram { get; set; }
        public string Inbound { get; set; }
        public string Outbound { get; set; }
        public int? License { get; set; }
        public string LoginType { get; set; }
        public DateTime? DateCreate { get; set; }
        public string UserCreate { get; set; }
    }
}
