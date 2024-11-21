using System.Net.Mime;
using System.Text;

namespace Utils
{
    public static class RequestCreator
    {
        public static HttpRequestMessage GetHttpRequest(Uri baseUri, string route, string body)
        {
            var req = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri(baseUri, route),
                Content = new StringContent(
                    body,
                    Encoding.UTF8,
                    MediaTypeNames.Application.Json
                )
            };
            Console.WriteLine( req.RequestUri );
            return req;
        }
    }
}
