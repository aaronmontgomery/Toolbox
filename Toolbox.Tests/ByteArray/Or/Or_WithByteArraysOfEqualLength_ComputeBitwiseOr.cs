using NUnit.Framework;

namespace ByteArray
{
    [TestFixture]
    public static partial class Or
    {
        [TestCase(new byte[] { 5, 5 }, new byte[] { 10, 10 }, ExpectedResult =new byte[] { 15, 15 })]
        [TestCase(new byte[] { 10, 5 }, new byte[] { 10, 5 }, ExpectedResult =new byte[] { 10, 5 })]
        public static byte[] Or_WithByteArraysOfEqualLength_ComputeBitwiseOr(byte[] b1, byte[] b2)
        {
            return Toolbox.ByteArray.Or(b1, b2);
        }
    }
}
