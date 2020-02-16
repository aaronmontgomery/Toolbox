using NUnit.Framework;
using System.Linq;

namespace Network
{
    [TestFixture]
    public static partial class SubnetRange
    {
        [TestCase(new byte[] { 10, 9, 9, 0 }, new byte[] { 255, 255, 255, 224 }, ExpectedResult =32)]
        [TestCase(new byte[] { 172, 100, 15, 137 }, new byte[] { 255, 255, 128, 0 }, ExpectedResult =32768)]
        [TestCase(new byte[] { 10, 0, 0, 1 }, new byte[] { 255, 0, 0, 0 }, ExpectedResult =16777216)]
        public static int SubnetRange_WithSubnetIpAndSubnetMask_CalculateNumberOfHosts(byte[] subnetIp, byte[] subnetMask)
        {
            return Toolbox.Network.SubnetRange(subnetIp, subnetMask).Count();
        }
    }
}
