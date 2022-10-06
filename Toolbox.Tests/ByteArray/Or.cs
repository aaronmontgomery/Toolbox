using System;
using NUnit.Framework;

namespace ByteArray
{
    [TestFixture]
    public static partial class Or
    {
        [TestCase(new byte[] { 5, 5 }, new byte[] { 10, 10 }, ExpectedResult =new byte[] { 15, 15 })]
        [TestCase(new byte[] { 10, 5 }, new byte[] { 10, 5 }, ExpectedResult =new byte[] { 10, 5 })]
        public static byte[] Or_WithByteArraysOfEqualLength_ComputeBitwiseOr(byte[] byteArray1, byte[] byteArray2)
        {
            return Toolbox.ByteArray.Or(byteArray1, byteArray2);
        }

        [TestCase(new byte[] { 5, 10 }, new byte[] { 10 })]
        public static void Or_WithByteArraysOfDifferentLength_ThrowIndexOutOfRangeException(byte[] byteArray1, byte[] byteArray2)
        {
            Assert.Throws<IndexOutOfRangeException>(() => Toolbox.ByteArray.Or(byteArray1, byteArray2));
        }

        [TestCase(new byte[] { }, new byte[] { 0 })]
        [TestCase(new byte[] { 0 }, new byte[] { })]
        [TestCase(new byte[] { }, new byte[] { })]
        public static void Or_WithEmpty_ThrowsArgumentException(byte[] byteArray1, byte[] byteArray2)
        {
            Assert.Throws<ArgumentException>(() => Toolbox.ByteArray.Or(byteArray1, byteArray2));
        }

        [TestCase(null, new byte[] { 0 })]
        [TestCase(new byte[] { 0 }, null)]
        [TestCase(null, null)]
        public static void Or_WithNull_ThrowsArgumentNullException(byte[] byteArray1, byte[] byteArray2)
        {
            Assert.Throws<ArgumentNullException>(() => Toolbox.ByteArray.Or(byteArray1, byteArray2));
        }
    }
}
