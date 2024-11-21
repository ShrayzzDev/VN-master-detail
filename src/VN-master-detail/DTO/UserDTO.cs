using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{   
    public class UserDTO
    {
        public string username { get; set; } = "";

        public string userId { get; set; } = "";

        public string[] permissions { get; set; } = [];

        public UserDTO(string username, string userId, string[] permissions)
        {
            this.username = username;
            this.userId = userId;
            this.permissions = permissions;
        }

        public UserDTO() { }
    }
}
