using NUnit.Framework;

namespace ByteArray
{
    [TestFixture]
    public static partial class InsertTrailingZeros
    {
        [TestCase(new byte[] { 0 }, 0)]
        public static void insert_trailing_zeros_argument_exception(byte[] b, int length)
        {
            Assert.Throws<System.ArgumentException>(() => Toolbox.ByteArray.InsertTrailingZeros(b, length));
        }
    }
}
