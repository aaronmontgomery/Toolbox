using System.Net;
using System.Collections.Generic;

namespace Toolbox
{
    public static partial class Network
    {
        /// <summary>
        /// Generate a list of IP Addresses within a subnet
        /// </summary>
        /// <param name="subnetIpBytes"></param>
        /// <param name="subnetMaskBytes"></param>
        /// <returns></returns>
        public static IEnumerable<IPAddress> SubnetRange(byte[] subnetIpBytes, byte[] subnetMaskBytes)
        {
            byte[] b;
            byte[] ipBytes;
            double hosts;
            List<IPAddress> ipAddresses;
            
            b = new byte[] { 1 };
            ipAddresses = new List<IPAddress>();
            ipBytes = ByteArray.And(subnetIpBytes, subnetMaskBytes);
            hosts = subnetMaskBytes.Not().Magnitude(256);
            for (; hosts >= 0; hosts--)
            {
                ipAddresses.Add(new IPAddress(ipBytes));
                ipBytes = ByteArray.Addition(ipBytes, b);
            }

            return ipAddresses;
        }
    }
}
