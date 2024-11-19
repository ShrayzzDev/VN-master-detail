using DTO;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stub
{
    public class UserStub : IUserRequestor
    {
        private Dictionary<string, UserDTO> _users = new()
        {
            {"jean-jean-jean-jean", new UserDTO("Jean","jean-jean-jean-jean",[]) }
        };


        public Task<UserDTO?> Login(string ApiKey)
        {
            return Task.Run(() => {
                if (_users.TryGetValue(ApiKey, out UserDTO? user))
                    return (UserDTO?)user;
                return null;
            });
        }
    }
}
