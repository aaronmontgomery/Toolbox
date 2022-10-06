using System;
using NUnit.Framework;

namespace ByteArray
{
    [TestFixture]
    public static partial class InsertLeadingZeros
    {
        [TestCase(new byte[] { 0 }, null, ExpectedResult = new byte[] { 0 })]
        [TestCase(new byte[] { 0 }, -1, ExpectedResult = new byte[] { 0 })]
        [TestCase(new byte[] { 0 }, 0, ExpectedResult = new byte[] { 0 })]
        [TestCase(new byte[] { 0 }, 1, ExpectedResult = new byte[] { 0 })]
        [TestCase(new byte[] { 0 }, 2, ExpectedResult = new byte[] { 0, 0 })]
        [TestCase(new byte[] { 5, 0, 15 }, 5, ExpectedResult = new byte[] { 0, 0, 5, 0, 15 })]
        public static byte[] InsertLeadingZeros_WithByeArrayAndLength_PadLeftWithZeros(byte[] byteArray, int length)
        {
            return Toolbox.ByteArray.InsertLeadingZeros(byteArray, length);
        }

        [TestCase(new byte[] { }, 2)]
        public static void InsertLeadingZeros_WithEmpty_ThrowsArgumentException(byte[] byteArray, int length)
        {
            Assert.Throws<ArgumentException>(() => Toolbox.ByteArray.InsertLeadingZeros(byteArray, length));
        }

        [TestCase(null, 2)]
        public static void InsertLeadingZeros_WithNull_ThrowsArgumentNullException(byte[] byteArray, int length)
        {
            Assert.Throws<ArgumentNullException>(() => Toolbox.ByteArray.InsertLeadingZeros(byteArray, length));
        }
    }
}
