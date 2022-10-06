using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Net;

namespace Toolbox
{
    public static partial class Services
    {
        public interface INetworkService
        {
            IAsyncEnumerable<PingReply> PingRange(IEnumerable<IPAddress> subnet);
        }
    }
}
