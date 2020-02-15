using NUnit.Framework;

namespace ByteArray
{
    [TestFixture]
    public static partial class Add
    {
        [TestCase(new byte[] { 0 }, new byte[] { 0 }, new byte[] { 0 })]
        public static void add_zero_byte_arrays_true(byte[] byte1, byte[] byte2, byte[] result)
        {
            Assert.AreEqual(Toolbox.ByteArray.Add(byte1, byte2), result);
        }
    }
}
