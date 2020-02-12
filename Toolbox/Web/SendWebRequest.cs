using System.Net;
using System.Collections.Generic;

namespace Toolbox
{
    public static class Web
    {
        /// <summary>
        /// 
        /// </summary>
        public static IEnumerable<object> SendWebRequest(WebRequest webRequest)
        {
            using WebResponse webResponse = webRequest.GetResponse();
            using System.IO.Stream stream = webResponse.GetResponseStream();
            return Stream.Read(stream);
        }
    }
}
