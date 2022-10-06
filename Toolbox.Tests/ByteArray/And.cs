using System;
using NUnit.Framework;

namespace ByteArray
{
    [TestFixture]
    public static partial class And
    {
        [TestCase(new byte[] { 10, 5 }, new byte[] { 10, 5 }, ExpectedResult = new byte[] { 10, 5 })]
        [TestCase(new byte[] { 5, 5 }, new byte[] { 10, 10 }, ExpectedResult = new byte[] { 0, 0 })]
        public static byte[] And_WithByteArraysOfEqualLength_ComputeBitwiseAnd(byte[] b1, byte[] b2)
        {
            return Toolbox.ByteArray.And(b1, b2);
        }

        [TestCase(new byte[] { 5, 10 }, new byte[] { 10 })]
        public static void And_WithByteArraysOfDifferentLengths_ThrowsIndexOutOfRangeException(byte[] b1, byte[] b2)
        {
            Assert.Throws<IndexOutOfRangeException>(() => Toolbox.ByteArray.And(b1, b2));
        }

        [TestCase(new byte[] {  }, new byte[] { 10 })]
        [TestCase(new byte[] { 10 }, new byte[] {  })]
        public static void And_WithEmpty_ThrowsArgumentException(byte[] b1, byte[] b2)
        {
            Assert.Throws<ArgumentException>(() => Toolbox.ByteArray.And(b1, b2));
        }

        [TestCase(null, new byte[] { 10 })]
        [TestCase(new byte[] { 10 }, null)]
        [TestCase(null, null)]
        public static void And_WithNull_ThrowsArgumentNullException(byte[] b1, byte[] b2)
        {
            Assert.Throws<ArgumentNullException>(() => Toolbox.ByteArray.And(b1, b2));
        }
    }
}
