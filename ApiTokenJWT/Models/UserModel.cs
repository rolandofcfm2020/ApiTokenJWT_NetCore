using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTokenJWT.Models
{
    public class UserModel
    {
        public string EmailAddress { get;  set; }
        public string Username { get;  set; }
        public string Password { get; set; }
    }
}
