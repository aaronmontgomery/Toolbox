using System;
using NUnit.Framework;

namespace ByteArray
{
    [TestFixture]
    public static partial class Addition
    {
        [TestCase(new byte[] { 0 }, new byte[] { 0 }, ExpectedResult = new byte[] { 0 })]
        [TestCase(new byte[] { 0 }, new byte[] { 5 }, ExpectedResult = new byte[] { 5 })]
        [TestCase(new byte[] { 5 }, new byte[] { 5, 10 }, ExpectedResult = new byte[] { 5, 15 })]
        [TestCase(new byte[] { 5, 10 }, new byte[] { 10 }, ExpectedResult = new byte[] { 5, 20 })]
        public static byte[] Addition_WithByteArrays_ComputeSum(byte[] byteArray1, byte[] byteArray2)
        {
            return Toolbox.ByteArray.Addition(byteArray1, byteArray2);
        }

        [TestCase(new byte[] {  }, new byte[] { 0 })]
        [TestCase(new byte[] { 0 }, new byte[] {  })]
        [TestCase(new byte[] {  }, new byte[] {  })]
        public static void Addition_WithEmpty_ThrowsArgumentException(byte[] byteArray1, byte[] byteArray2)
        {
            Assert.Throws<ArgumentException>(() => Toolbox.ByteArray.Addition(byteArray1, byteArray2));
        }

        [TestCase(null, new byte[] { 0 })]
        [TestCase(new byte[] { 0 }, null)]
        [TestCase(null, null)]
        public static void Addition_WithNull_ThrowsArgumentNullException(byte[] byteArray1, byte[] byteArray2)
        {
            Assert.Throws<ArgumentNullException>(() => Toolbox.ByteArray.Addition(byteArray1, byteArray2));
        }
    }
}
