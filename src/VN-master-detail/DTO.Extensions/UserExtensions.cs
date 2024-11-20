using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Extensions
{
    public static class UserExtensions
    {
        public static User ToModel(this UserDTO dto)
        {
            return new User(
                dto.username,
                dto.userId,
                dto.permissions
            );
        }
    }
}
