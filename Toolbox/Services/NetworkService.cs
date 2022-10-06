using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;

namespace Toolbox
{
    public static partial class Services
    {
        public class NetworkService : INetworkService
        {
            public async IAsyncEnumerable<PingReply> PingRange(IEnumerable<IPAddress> subnet)
            {
                Ping ping;
                PingReply pingReply;

                foreach (IPAddress subnetIpAddress in subnet)
                {
                    using (ping = new Ping())
                    {
                        pingReply = await ping.SendPingAsync(subnetIpAddress);
                        if (pingReply.Status == IPStatus.Success)
                        {
                            yield return pingReply;
                        }
                    }
                }
            }
        }
    }
}
