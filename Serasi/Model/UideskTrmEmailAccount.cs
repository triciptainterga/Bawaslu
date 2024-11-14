using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class UideskTrmEmailAccount
    {
        public int RecId { get; set; }
        public string Name { get; set; }
        public string IncomingAccountName { get; set; }
        public string IncomingPassword { get; set; }
        public string IncomingServer { get; set; }
        public string IncomingPort { get; set; }
        public int? IncomingAuthtype { get; set; }
        public string EncryptedConnection { get; set; }
        public string OutgoingAccountName { get; set; }
        public string OutgoingPassword { get; set; }
        public string OutgoingServer { get; set; }
        public string OutgoingPort { get; set; }
        public string EncryptedConnectionOut { get; set; }
        public string NeedLogin { get; set; }
        public string IncomingBackUp { get; set; }
        public string OutgoingBackUp { get; set; }
        public string ServerProtocol { get; set; }
        public string ServerProtocolOut { get; set; }
        public int? ServerProfileId { get; set; }
        public int? EmailSignitureId { get; set; }
        public int? EmailServiceMethodId { get; set; }
        public string Status { get; set; }
        public string SiteId { get; set; }
        public string Clientid { get; set; }
        public string Clientsecret { get; set; }
        public string PublicUrl { get; set; }
    }
}
