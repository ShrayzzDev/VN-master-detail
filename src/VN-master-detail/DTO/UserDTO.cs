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

        public string apiKey { get; set; } = "";

        public string[] permissions { get; set; } = [];

        public UserDTO(string username, string apiKey, string[] permissions)
        {
            this.username = username;
            this.apiKey = apiKey;
            this.permissions = permissions;
        }

        public UserDTO() { }
    }
}
