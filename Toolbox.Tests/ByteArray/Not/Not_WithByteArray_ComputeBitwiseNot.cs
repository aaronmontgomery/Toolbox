using NUnit.Framework;
using Toolbox;

namespace ByteArray
{
    [TestFixture]
    public static partial class Not
    {
        [TestCase(new byte[] { 3 }, ExpectedResult =new byte[] { 252 })]
        [TestCase(new byte[] { 5, 10 }, ExpectedResult =new byte[] { 250, 245 })]
        public static byte[] Not_WithByteArray_ComputeBitwiseNot(byte[] b)
        {
            return b.Not();
        }
    }
}
