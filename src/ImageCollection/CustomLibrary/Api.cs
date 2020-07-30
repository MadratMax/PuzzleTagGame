using System.Net;

namespace PuzzleTag
{
    class Api
    {
        private static HttpWebRequest _request;

        public static HttpWebRequest GetRequest(string url)
        {
            _request = (HttpWebRequest)WebRequest.Create(url);

            return _request;
        }

        public static HttpWebResponse GetResponse(HttpWebRequest request) => (HttpWebResponse)request.GetResponse();
    }
}