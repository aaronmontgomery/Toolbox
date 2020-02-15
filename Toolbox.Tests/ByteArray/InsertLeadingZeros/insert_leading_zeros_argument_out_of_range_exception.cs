using NUnit.Framework;

namespace ByteArray
{
    [TestFixture]
    public static partial class InsertLeadingZeros
    {
        [TestCase(new byte[] { 0 }, 0)]
        public static void insert_leading_zeros_exception(byte[] b, int length)
        {
            Assert.Throws<System.ArgumentOutOfRangeException>(() => Toolbox.ByteArray.InsertLeadingZeros(b, length));
        }
    }
}
