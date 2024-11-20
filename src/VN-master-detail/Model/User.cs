using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class User
    {
        public string UserId { get; set; }

        public string Username { get; set; }

        public string ApiKey { get; set; } = "";

        public string[] Permissions { get; set; }

        public User(string username, string userId, string[] permissions)
        {
            Username = username;
            UserId = userId;
            Permissions = permissions;
        }

        public User()
            : this("", "", []) { }
    }
}
