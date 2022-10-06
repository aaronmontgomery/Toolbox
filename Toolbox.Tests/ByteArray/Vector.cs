using System;
using NUnit.Framework;
using Toolbox;

namespace ByteArray
{
    [TestFixture]
    public static partial class Vector
    {
        [TestCase(0, 2, ExpectedResult = new byte[] { 0 })]
        [TestCase(5, 2, ExpectedResult = new byte[] { 1, 0, 1 })]
        [TestCase(255, 256, ExpectedResult = new byte[] { 255 })]
        [TestCase(511, 256, ExpectedResult = new byte[] { 1, 255 })]
        [TestCase(131071, 256, ExpectedResult = new byte[] { 1, 255, 255 })]
        [TestCase(33554431, 256, ExpectedResult = new byte[] { 1, 255, 255, 255 })]
        [TestCase(4294967295, 256, ExpectedResult = new byte[] { 255, 255, 255, 255 })]
        public static byte[] Vector_WithByteArrayAndBits_ComputeVector(double magnitude, int bits)
        {
            return magnitude.Vector(bits);
        }

        [TestCase(0, 0)]
        [TestCase(10, -8)]
        [TestCase(-10, 8)]
        public static void Vector_WithMagnitudeNegativeOrBitsZeroNegative_ThrowsArgumentException(double magnitude, int bits)
        {
            Assert.Throws<ArgumentException>(() => magnitude.Vector(bits));
        }
    }
}
