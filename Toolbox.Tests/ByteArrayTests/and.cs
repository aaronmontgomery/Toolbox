using NUnit.Framework;

[TestFixture]
public partial class ByteArrayTests
{
    [TestCase(new byte[] { 10, 5 }, new byte[] { 10, 5 }, ExpectedResult = new byte[] { 10, 5 })]
    [TestCase(new byte[] { 5, 5 }, new byte[] { 10, 10 }, ExpectedResult = new byte[] { 0, 0 })]
    public byte[] bitwise_and(byte[] b1, byte[] b2)
    {
        return Toolbox.ByteArray.And(b1, b2);
    }

    [TestCase(new byte[] { 5, 10 }, new byte[] { 10 })]
    public void bitwise_and_exception(byte[] b1, byte[] b2)
    {
        Assert.Throws<System.IndexOutOfRangeException>(() => Toolbox.ByteArray.And(b1, b2));
    }
}
