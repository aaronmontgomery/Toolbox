using System;
using System.Linq;
using NUnit.Framework;

namespace Network
{
    [TestFixture]
    public static class SubnetRange
    {
        [TestCase(new byte[] { 10, 9, 9, 0 }, new byte[] { 255, 255, 255, 224 }, ExpectedResult = 32)]
        [TestCase(new byte[] { 172, 100, 15, 137 }, new byte[] { 255, 255, 128, 0 }, ExpectedResult = 32768)]
        [TestCase(new byte[] { 10, 0, 0, 1 }, new byte[] { 255, 0, 0, 0 }, ExpectedResult = 16777216)]
        public static int SubnetRange_WithSubnetIpAndSubnetMask_CalculateNumberOfHosts(byte[] subnetIp, byte[] subnetMask)
        {
            return Toolbox.Network.SubnetRange(subnetIp, subnetMask).Count();
        }

        [TestCase(new byte[] {  }, new byte[] { 0 })]
        [TestCase(new byte[] { 0 }, new byte[] {  })]
        public static void SubnetRange_WithEmpty_ThrowsArgumentException(byte[] subnetIp, byte[] subnetMask)
        {
            Assert.Throws<ArgumentException>(() => Toolbox.Network.SubnetRange(subnetIp, subnetMask));
        }

        [TestCase(null, new byte[] { 0 })]
        [TestCase(new byte[] { 0 }, null)]
        public static void SubnetRange_WithNull_ThrowsArgumentNullException(byte[] subnetIp, byte[] subnetMask)
        {
            Assert.Throws<ArgumentNullException>(() => Toolbox.Network.SubnetRange(subnetIp, subnetMask));
        }
    }
}
