using DTO;
using DTO.Novel;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace APIRequestor
{

    public class UserApiRequestor : MainRequestor, IUserRequestor
    {
        public async Task<UserDTO?> Login(string ApiKey)
        {
            UserDTO? novel = null;
            HttpResponseMessage response = await client.SendAsync(
                RequestCreator.GetHttpRequest(client.BaseAddress, "authinfo", "", HttpMethod.Get, ApiKey));
            if (response.IsSuccessStatusCode)
            {
                novel = await response.Content.ReadFromJsonAsync<UserDTO>();
            }
            return novel;
        }
    }
}
