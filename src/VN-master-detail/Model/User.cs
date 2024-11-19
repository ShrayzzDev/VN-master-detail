using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class User
    {
        public string Username { get; set; }

        public string ApiKey { get; set; }

        public string[] Permissions { get; set; }

        public User(string username, string apiKey, string[] permissions)
        {
            Username = username;
            ApiKey = apiKey;
            Permissions = permissions;
        }

        public User()
            : this("", "", []) { }
    }
}
