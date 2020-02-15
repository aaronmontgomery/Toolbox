using NUnit.Framework;

namespace ByteArray
{
    [TestFixture]
    public static partial class Add
    {
        [TestCase(new byte[] { }, new byte[] { 0 })]
        public static void add_empty_byte_arrays_null_reference_exception(byte[] byte1, byte[] byte2)
        {
            Assert.Throws<System.NullReferenceException>(() => Toolbox.ByteArray.Add(byte1, byte2));
        }
    }
}
