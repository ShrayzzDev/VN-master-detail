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
        public async Task<IEnumerable<LabelDTO>> GetLabels(string apiKey)
        {
            IEnumerable<LabelDTO>? labels = null;
            HttpResponseMessage response = await client.SendAsync(
                RequestCreator.GetHttpRequest(client.BaseAddress, "ulist_labels", "", HttpMethod.Get, apiKey));
            Console.WriteLine(await response.Content.ReadAsStringAsync());
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadFromJsonAsync<LabelResultDTO>();
                labels = result == null ? [] : result.labels;
            }
            return labels ?? [];
        }

        public async Task<UserDTO?> Login(string ApiKey)
        {
            UserDTO? user = null;
            HttpResponseMessage response = await client.SendAsync(
                RequestCreator.GetHttpRequest(client.BaseAddress, "authinfo", "", HttpMethod.Get, ApiKey));
            if (response.IsSuccessStatusCode)
            {
                user = await response.Content.ReadFromJsonAsync<UserDTO>();
            }
            return user;
        }
    }
}
