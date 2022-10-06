using System;
using NUnit.Framework;
using Toolbox;

namespace ByteArray
{
    [TestFixture]
    public static partial class Magnitude
    {
        [TestCase(new byte[] { 1, 0, 1 }, 2, ExpectedResult = 5)]
        [TestCase(new byte[] { 0, 0, 0, 0 }, 256, ExpectedResult = 0)]
        [TestCase(new byte[] { 0, 0, 0, 255 }, 256, ExpectedResult = 255)]
        [TestCase(new byte[] { 0, 0, 1, 255 }, 256, ExpectedResult = 511)]
        [TestCase(new byte[] { 0, 1, 255, 255 }, 256, ExpectedResult = 131071)]
        [TestCase(new byte[] { 1, 255, 255, 255 }, 256, ExpectedResult = 33554431)]
        [TestCase(new byte[] { 255, 255, 255, 255 }, 256, ExpectedResult = 4294967295)]
        public static double Magnitude_WithBitsPositive_ComputeMagnitude(byte[] byteArray, int bits)
        {
            return byteArray.Magnitude(bits);
        }

        [TestCase(new byte[] { 0 }, 0)]
        [TestCase(new byte[] { }, 256)]
        [TestCase(new byte[] { 1, 0, 1 }, -1)]
        public static void Magnitude_WithByteArrayEmptyAndBitsZeroOrNegative_ThrowsArgumentException(byte[] byteArray, int bits)
        {
            Assert.Throws<ArgumentException>(() => byteArray.Magnitude(bits));
        }

        [TestCase(null, 256)]
        public static void Magnitude_WithNull_ThrowsArgumentNullException(byte[] byteArray, int bits)
        {
            Assert.Throws<ArgumentNullException>(() => byteArray.Magnitude(bits));
        }
    }
}
