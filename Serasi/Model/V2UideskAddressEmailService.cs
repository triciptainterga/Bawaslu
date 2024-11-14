using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class V2UideskAddressEmailService
    {
        public int Id { get; set; }
        public string EmailAddress { get; set; }
        public string EmailType { get; set; }
        public string Username { get; set; }
        public DateTime? Datecreate { get; set; }
    }
}
