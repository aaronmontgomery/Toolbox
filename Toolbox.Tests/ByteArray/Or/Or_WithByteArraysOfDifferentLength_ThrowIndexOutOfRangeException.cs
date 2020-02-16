using NUnit.Framework;

namespace ByteArray
{
    [TestFixture]
    public static partial class Or
    {
        [TestCase(new byte[] { 5, 10 }, new byte[] { 10 })]
        public static void Or_WithByteArraysOfDifferentLength_ThrowIndexOutOfRangeException(byte[] b1, byte[] b2)
        {
            Assert.Throws<System.IndexOutOfRangeException>(() => Toolbox.ByteArray.Or(b1, b2));
        }
    }
}
