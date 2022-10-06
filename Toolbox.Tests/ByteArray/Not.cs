using System;
using NUnit.Framework;
using Toolbox;

namespace ByteArray
{
    [TestFixture]
    public static partial class Not
    {
        [TestCase(new byte[] { 3 }, ExpectedResult = new byte[] { 252 })]
        [TestCase(new byte[] { 5, 10 }, ExpectedResult = new byte[] { 250, 245 })]
        public static byte[] Not_WithByteArray_ComputeBitwiseNot(byte[] byteArray)
        {
            return byteArray.Not();
        }

        [TestCase(new byte[] { })]
        public static void Not_WithEmpty_ThrowsArgumentException(byte[] byteArray)
        {
            Assert.Throws<ArgumentException>(() => byteArray.Not());
        }

        [TestCase(null)]
        public static void Not_WithNull_ThrowsArgumentNullException(byte[] byteArray)
        {
            Assert.Throws<ArgumentNullException>(() => byteArray.Not());
        }
    }
}
