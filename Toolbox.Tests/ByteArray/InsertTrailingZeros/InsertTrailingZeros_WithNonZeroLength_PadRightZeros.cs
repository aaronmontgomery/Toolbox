using NUnit.Framework;

namespace ByteArray
{
    [TestFixture]
    public static partial class InsertTrailingZeros
    {
        [TestCase(new byte[] { 0 }, 2, ExpectedResult =new byte[] { 0, 0 })]
        [TestCase(new byte[] { 5, 0, 15 }, 5, ExpectedResult =new byte[] { 5, 0, 15, 0, 0 })]
        public static byte[] InsertTrailingZeros_WithNonZeroLength_PadRightZeros(byte[] b, int length)
        {
            return Toolbox.ByteArray.InsertTrailingZeros(b, length);
        }
    }
}
