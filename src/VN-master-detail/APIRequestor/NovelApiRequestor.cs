using DTO;
using DTO.Novel;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using Utils;

namespace APIRequestor
{
    public class NovelApiRequestor : MainRequestor, INovelRequestor
    {
        public async Task<DetailedNovelDTO?> GetDetailedNovelById(string id)
        {
            DetailedNovelDTO? novel = null;
            HttpResponseMessage response = await client.SendAsync(
                RequestCreator.GetHttpRequest(client.BaseAddress, "vn",
                HttpRequestBodies.DetailedNovelFields));
            if (response.IsSuccessStatusCode)
            {
                novel = await response.Content.ReadFromJsonAsync<DetailedNovelDTO>();
            }
            return novel;
        }

        public async Task<IEnumerable<BasicNovelDTO?>?> GetNovelByOrder(int index, int count, Criteria criteria)
        {
            BasicResultsDTO? novels = null;
            HttpResponseMessage response = await client.SendAsync(
                RequestCreator.GetHttpRequest(client.BaseAddress, "vn",
                $"{{\"sort\": \"{criteria.AsString()}\", " +
                $"\"page\": {index}, " +
                $"\"results\": {count}, " +
                HttpRequestBodies.BasicNovelFields + "}")
            );
            Console.WriteLine(await response.Content.ReadAsStringAsync());
            if (response.IsSuccessStatusCode)
            {
                novels = await response.Content.ReadFromJsonAsync<BasicResultsDTO>();
            }
            return novels?.results;
        }

        public async Task<BasicNovelDTO?> GetNovelById(string id)
        {
            BasicNovelDTO? novel = null;
            HttpResponseMessage response = await client.SendAsync(
                RequestCreator.GetHttpRequest(client.BaseAddress, "vn", 
                UTF8Converter.GetUTF8String("{\"filters\": [\"id\", \"=\", \"" + id + "\"], " + HttpRequestBodies.BasicNovelFields + "}"))
            );
            if (response.IsSuccessStatusCode)
            {
                novel = (await response.Content.ReadFromJsonAsync<BasicResultsDTO>())?.results.First();
            }
            return novel;
        }

        public async Task<IEnumerable<BasicNovelDTO?>?> GetNovelByCriteria(int index, int count, string which, string value)
        {
            List<BasicNovelDTO?>? novels = null;
            HttpResponseMessage response = await client.SendAsync(
                RequestCreator.GetHttpRequest(client.BaseAddress, "vn",
                $"\"filters\": [\"{which}\", \"=\", \"{value }\"],\n" +
                $"\"page\": {index},\n" +
                $"\"result\": {count}," +
                HttpRequestBodies.BasicNovelFields)
            );
            if (response.IsSuccessStatusCode)
            {
                novels = await response.Content
                    .ReadFromJsonAsAsyncEnumerable<BasicNovelDTO>()
                    .ToListAsync();
                novels.RemoveAll(item => item == null);
            }
            return novels;
        }

        public Task<IEnumerable<BasicNovelDTO?>?> GetNovelForUser(string userId)
        {
            throw new NotImplementedException();
        }
    }
}
