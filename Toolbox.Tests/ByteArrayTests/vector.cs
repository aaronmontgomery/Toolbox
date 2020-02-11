using NUnit.Framework;
using Toolbox;

[TestFixture]
public partial class ByteArrayTests
{
    [TestCase(0, 2, ExpectedResult = new byte[] { 0 })]
    [TestCase(5, 2, ExpectedResult = new byte[] { 1, 0, 1 })]
    [TestCase(0, 256, ExpectedResult = new byte[] { 0 })]
    [TestCase(255, 256, ExpectedResult = new byte[] { 255 })]
    [TestCase(511, 256, ExpectedResult = new byte[] { 1, 255 })]
    [TestCase(131071, 256, ExpectedResult = new byte[] { 1, 255, 255 })]
    [TestCase(33554431, 256, ExpectedResult = new byte[] { 1, 255, 255, 255 })]
    [TestCase(4294967295, 256, ExpectedResult = new byte[] { 255, 255, 255, 255 })]
    public byte[] vector(double magnitude, int bits)
    {
        return magnitude.Vector(bits);
    }
}