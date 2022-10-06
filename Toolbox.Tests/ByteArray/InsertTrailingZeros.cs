using System;
using NUnit.Framework;

namespace ByteArray
{
    [TestFixture]
    public static partial class InsertTrailingZeros
    {
        [TestCase(new byte[] { 0 }, null, ExpectedResult = new byte[] { 0 })]
        [TestCase(new byte[] { 0 }, -1, ExpectedResult = new byte[] { 0 })]
        [TestCase(new byte[] { 0 }, 0, ExpectedResult = new byte[] { 0 })]
        [TestCase(new byte[] { 0 }, 1, ExpectedResult = new byte[] { 0 })]
        [TestCase(new byte[] { 0 }, 2, ExpectedResult = new byte[] { 0, 0 })]
        [TestCase(new byte[] { 5, 0, 15 }, 5, ExpectedResult = new byte[] { 5, 0, 15, 0, 0 })]
        public static byte[] InsertTrailingZeros_WithByeArrayAndLength_PadRightWithZeros(byte[] byteArray, int length)
        {
            return Toolbox.ByteArray.InsertTrailingZeros(byteArray, length);
        }

        [TestCase(new byte[] { }, 2)]
        public static void InsertTrailingZeros_WithEmpty_ThrowsArgumentException(byte[] byteArray, int length)
        {
            Assert.Throws<ArgumentException>(() => Toolbox.ByteArray.InsertTrailingZeros(byteArray, length));
        }

        [TestCase(null, 2)]
        public static void InsertTrailingZeros_WithNull_ThrowsArgumentNullException(byte[] byteArray, int length)
        {
            Assert.Throws<ArgumentNullException>(() => Toolbox.ByteArray.InsertTrailingZeros(byteArray, length));
        }
    }
}
