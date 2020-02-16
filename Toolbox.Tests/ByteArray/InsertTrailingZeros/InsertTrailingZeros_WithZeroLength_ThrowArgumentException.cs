using NUnit.Framework;

namespace ByteArray
{
    [TestFixture]
    public static partial class InsertTrailingZeros
    {
        [TestCase(new byte[] { 0 }, 0)]
        public static void InsertTrailingZeros_WithZeroLength_ThrowArgumentException(byte[] b, int length)
        {
            Assert.Throws<System.ArgumentException>(() => Toolbox.ByteArray.InsertTrailingZeros(b, length));
        }
    }
}
