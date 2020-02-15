using NUnit.Framework;

namespace ByteArray
{
    [TestFixture]
    public static partial class InsertLeadingZeros
    {
        [TestCase(new byte[] { 0 }, 2, ExpectedResult = new byte[] { 0, 0 })]
        [TestCase(new byte[] { 5, 0, 15 }, 5, ExpectedResult = new byte[] { 0, 0, 5, 0, 15 })]
        public static byte[] insert_leading_zeros(byte[] b, int length)
        {
            return Toolbox.ByteArray.InsertLeadingZeros(b, length);
        }
    }
}
