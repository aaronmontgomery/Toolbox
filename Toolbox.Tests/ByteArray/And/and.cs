using NUnit.Framework;

namespace ByteArray
{
    [TestFixture]
    public static partial class And
    {
        [TestCase(new byte[] { 10, 5 }, new byte[] { 10, 5 }, ExpectedResult = new byte[] { 10, 5 })]
        [TestCase(new byte[] { 5, 5 }, new byte[] { 10, 10 }, ExpectedResult = new byte[] { 0, 0 })]
        public static byte[] and(byte[] b1, byte[] b2)
        {
            return Toolbox.ByteArray.And(b1, b2);
        }
    }
}
