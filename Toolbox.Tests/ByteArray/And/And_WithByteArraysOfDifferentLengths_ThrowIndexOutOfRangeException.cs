using NUnit.Framework;

namespace ByteArray
{
    [TestFixture]
    public static partial class And
    {
        [TestCase(new byte[] { 5, 10 }, new byte[] { 10 })]
        public static void And_WithByteArraysOfDifferentLengths_ThrowIndexOutOfRangeException(byte[] b1, byte[] b2)
        {
            Assert.Throws<System.IndexOutOfRangeException>(() => Toolbox.ByteArray.And(b1, b2));
        }
    }
}
