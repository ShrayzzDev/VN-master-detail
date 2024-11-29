using System.Net.Http.Headers;
using System.Net.Mime;
using System.Text;

namespace Utils
{
    public static class RequestCreator
    {
        public static HttpRequestMessage GetHttpRequest(Uri baseUri, string route, string body, HttpMethod method, string authtoken = "")
        {
            var req = new HttpRequestMessage
            {
                Method = method,
                RequestUri = new Uri(baseUri, route),
                Content = new StringContent(
                    body,
                    Encoding.UTF8,
                    MediaTypeNames.Application.Json
                )
            };

            if (!string.IsNullOrWhiteSpace(authtoken))
                req.Headers.Authorization = new AuthenticationHeaderValue("token", authtoken);

            return req;
        }
    }
}
