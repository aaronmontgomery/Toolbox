using NUnit.Framework;

namespace ByteArray
{
    [TestFixture]
    public static partial class InsertLeadingZeros
    {
        [TestCase(new byte[] { 0 }, 0)]
        public static void InsertLeadingZeros_WithZeroLength_ThrowArgumentOutOfRangeException(byte[] b, int length)
        {
            Assert.Throws<System.ArgumentOutOfRangeException>(() => Toolbox.ByteArray.InsertLeadingZeros(b, length));
        }
    }
}
