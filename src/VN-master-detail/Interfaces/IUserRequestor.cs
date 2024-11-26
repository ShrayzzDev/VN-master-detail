﻿using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IUserRequestor
    {
        /// <summary>
        /// Logs the user
        /// </summary>
        /// <param name="ApiKey">Api key of the user</param>
        /// <returns>The user infos. Null if not found</returns>
        public Task<UserDTO?> Login(string ApiKey);

        /// <summary>
        /// Gets the list of labels for User
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public Task<IEnumerable<LabelDTO>> GetLabels(string apiKey);
    }
}
