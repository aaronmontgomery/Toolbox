using NUnit.Framework;
using Toolbox;

namespace ByteArray
{
    [TestFixture]
    public static partial class Magnitude
    {
        [TestCase(new byte[] { 1, 0, 1 }, 2, ExpectedResult = 5)]
        [TestCase(new byte[] { 0, 0, 0, 0 }, 256, ExpectedResult = 0)]
        [TestCase(new byte[] { 0, 0, 0, 255 }, 256, ExpectedResult = 255)]
        [TestCase(new byte[] { 0, 0, 1, 255 }, 256, ExpectedResult = 511)]
        [TestCase(new byte[] { 0, 1, 255, 255 }, 256, ExpectedResult = 131071)]
        [TestCase(new byte[] { 1, 255, 255, 255 }, 256, ExpectedResult = 33554431)]
        [TestCase(new byte[] { 255, 255, 255, 255 }, 256, ExpectedResult = 4294967295)]
        public static double magnitude(byte[] b, int bits)
        {
            return b.Magnitude(bits);
        }
    }
}
