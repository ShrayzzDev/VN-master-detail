using DTO;
using DTO.Novel;
using Interfaces;
using Model.Novel;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Reflection;
using System.Text;
using System.Xml.Linq;
using Utils;

namespace APIRequestor
{
    public class NovelApiRequestor : MainRequestor, INovelRequestor
    {
        /// <inheritdoc/>
        public async Task<DetailedNovelDTO?> GetDetailedNovelById(string id)
        {
            DetailedNovelDTO? novel = null;
            HttpResponseMessage response = await client.SendAsync(
                RequestCreator.GetHttpRequest(client.BaseAddress, "vn",
                "{\"filters\": [\"id\", \"=\", \"" + id + "\"], " + HttpRequestBodies.DetailedNovelFields + "}",
                HttpMethod.Post));  
            if (response.IsSuccessStatusCode)
            {
                novel = (await response.Content.ReadFromJsonAsync<DetailedResultDTO>())?.results.First();
            }
            return novel;
        }

        /// <inheritdoc/>
        public async Task<BasicResultsDTO?> GetNovelByOrder(int index, int count, Criteria criteria)
        {
            BasicResultsDTO? novels = null;
            HttpResponseMessage response = await client.SendAsync(
                RequestCreator.GetHttpRequest(client.BaseAddress, "vn",
                $"{{\"sort\": \"{criteria.AsString()}\", " +
                $"\"page\": {index}, " +
                $"\"results\": {count}, " +
                HttpRequestBodies.BasicNovelFields + "}",
                HttpMethod.Post)
            );

            if (response.IsSuccessStatusCode)
            {
                novels = await response.Content.ReadFromJsonAsync<BasicResultsDTO>();
            }
            return novels;
        }

        /// <inheritdoc/>
        public async Task<BasicNovelDTO?> GetNovelById(string id)
        {
            BasicNovelDTO? novel = null;
            HttpResponseMessage response = await client.SendAsync(
                RequestCreator.GetHttpRequest(client.BaseAddress, "vn", 
                UTF8Converter.GetUTF8String("{\"filters\": [\"id\", \"=\", \"" + id + "\"], " + HttpRequestBodies.BasicNovelFields + "}"),
                HttpMethod.Post)
            );
            if (response.IsSuccessStatusCode)
            {
                novel = (await response.Content.ReadFromJsonAsync<BasicResultsDTO>())?.results.First();
            }
            return novel;
        }

        // TODO : This requests wont work like that.
        // I just need to get the project to compile
        /// <inheritdoc/>
        public async Task<BasicResultsDTO?> GetNovelByCriteria(int index, int count, string which, string value)
        {
            List<BasicNovelDTO?>? novels = null;
            HttpResponseMessage response = await client.SendAsync(
                RequestCreator.GetHttpRequest(client.BaseAddress, "vn",
                $"\"filters\": [\"{which}\", \"=\", \"{value }\"],\n" +
                $"\"page\": {index},\n" +
                $"\"result\": {count}," +
                HttpRequestBodies.BasicNovelFields,
                HttpMethod.Post)
            );
            if (response.IsSuccessStatusCode)
            {
                novels = await response.Content
                    .ReadFromJsonAsAsyncEnumerable<BasicNovelDTO>()
                    .ToListAsync();
                novels.RemoveAll(item => item == null);
            }
            return new BasicResultsDTO(novels, false);
        }

        /// <inheritdoc/>
        public async Task<BasicUserResultsDTO?> GetNovelForUser(int index, int count, string userId)
        {
            BasicUserResultsDTO? novels = null;
            HttpResponseMessage response = await client.SendAsync(
                RequestCreator.GetHttpRequest(client.BaseAddress, "ulist", "{" +
                $"\"user\": \"{userId}\", " +
                $"\"page\": {index}, " +
                $"\"results\": {count}, " +
                HttpRequestBodies.BasicUserNovelFields + "}",
                HttpMethod.Post)
            );
            if (response.IsSuccessStatusCode)
            {
                novels = await response.Content.ReadFromJsonAsync<BasicUserResultsDTO>();
            }
            return novels;
        }

        /// <inheritdoc/>
        public async Task<BasicResultsDTO?> GetNovelByOrder(int index, int count, Criteria criteria, string name)
        {
            BasicResultsDTO? novels = null;
            HttpResponseMessage response = await client.SendAsync(
                RequestCreator.GetHttpRequest(client.BaseAddress, "vn",
                $"\"filters\": [\"title\", \"=\", \"{name}\"]" +
                $"{{\"sort\": \"{criteria.AsString()}\", " +
                $"\"page\": {index}, " +
                $"\"results\": {count}, " +
                HttpRequestBodies.BasicNovelFields + "}",
                HttpMethod.Post)
            );

            if (response.IsSuccessStatusCode)
            {
                novels = await response.Content.ReadFromJsonAsync<BasicResultsDTO>();
            }
            return novels;
        }

        /// <inheritdoc/>
        public async Task<bool> AddNovelToUserList(string novelId, string apiToken)
        {
            BasicResultsDTO? novels = null;
            HttpResponseMessage response = await client.SendAsync(
                RequestCreator.GetHttpRequest(client.BaseAddress, $"ulist/{novelId}",
                "{" + "}",
                HttpMethod.Patch,
                apiToken)
            );

            return response.IsSuccessStatusCode;
        }

        /// <inheritdoc/>
        public Task<bool> DoesUserHaveNovel(string novelId, string userid)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<bool> DeleteNovelFromUser(string novelId, string apiToken)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<bool> ChangeUserNovel(string novelId, string userId, int newGrade, int label)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<(int, int)> GetUserNovelInfos(string novelId, string userId)
        {
            throw new NotImplementedException();
        }
    }
}
