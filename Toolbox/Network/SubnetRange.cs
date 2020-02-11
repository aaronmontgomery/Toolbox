using System.Net;
using System.Collections.Generic;

namespace Toolbox
{
    public static partial class Network
    {
        /// <summary>
        /// Generate list of ip in subnet
        /// </summary>
        public static IEnumerable<IPAddress> SubnetRange(byte[] subnetIp, byte[] subnetMask)
        {
            List<IPAddress> r = new List<IPAddress>();
            byte[] i = ByteArray.And(subnetIp, subnetMask);
            double h = subnetMask.Not().Magnitude(256);
            for (; h >= 0; h--)
            {
                r.Add(new IPAddress(i));
                i = ByteArray.Add(i, new byte[] { 1 });
            }

            return r;
        }
    }
}
