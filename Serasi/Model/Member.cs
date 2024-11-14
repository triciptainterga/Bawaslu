using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiBravo.Models
{
    public class Member
    {
        public int Id { get; set; }
        public string Userid { get; set; }
        public DateTime? AccessToken { get; set; }
        public string RoleId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime? Datecreate { get; set; }

    }
}
