using NUnit.Framework;

namespace ByteArray
{
    [TestFixture]
    public static partial class Add
    {
        [TestCase(new byte[] { }, new byte[] { 0 }, ExpectedResult =new byte[] { 0 })]
        [TestCase(new byte[] { 0 }, new byte[] { 0 }, ExpectedResult =new byte[] { 0 })]
        [TestCase(new byte[] { 0 }, new byte[] { 5 }, ExpectedResult =new byte[] { 5 })]
        [TestCase(new byte[] { 5 }, new byte[] { 5, 10 }, ExpectedResult =new byte[] { 5, 15 })]
        [TestCase(new byte[] { 5, 10 }, new byte[] { 10 }, ExpectedResult =new byte[] { 5, 20 })]
        public static byte[] Add_WithByteArrays_ComputeSum(byte[] byte1, byte[] byte2)
        {
            return Toolbox.ByteArray.Add(byte1, byte2);
        }
    }
}
