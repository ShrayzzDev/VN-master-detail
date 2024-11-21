using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIRequestor
{
    /// <summary>
    /// Class herited by all class making
    /// HTTP requests to APIs.
    /// Main purpose is to have a unique instance
    /// of the Http Client (as recommanded).
    /// </summary>
    public abstract class MainRequestor
    {
        protected readonly static HttpClient client = new HttpClient();

        protected const string URL = "https://api.vndb.org/kana/";

        public MainRequestor()
        {
            client.BaseAddress = new Uri(URL);
        }
    }
}
