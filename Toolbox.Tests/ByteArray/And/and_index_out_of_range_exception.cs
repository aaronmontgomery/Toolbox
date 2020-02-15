using NUnit.Framework;

namespace ByteArray
{
    [TestFixture]
    public static partial class And
    {
        [TestCase(new byte[] { 5, 10 }, new byte[] { 10 })]
        public static void and_index_out_of_range_exception(byte[] b1, byte[] b2)
        {
            Assert.Throws<System.IndexOutOfRangeException>(() => Toolbox.ByteArray.And(b1, b2));
        }
    }
}
