using System;
using System.Net;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;

namespace Toolbox
{
    public static class Web
    {
        public static async Task<IEnumerable<object>> SendWebRequest(WebRequest webRequest)
        {
            try
            {
                using (WebResponse webResponse = webRequest.GetResponse())
                {
                    using (System.IO.Stream stream = webResponse.GetResponseStream())
                    {
                        return await Stream.ReadAsync(stream);
                    }
                }
            }

            catch (Exception exception)
            {
                new LoggerFactory()
                    .CreateLogger("Toolbox.Web.SendWebRequest")
                    .LogError(exception, "", new object[] { });
            }

            return null;
        }
    }
}
