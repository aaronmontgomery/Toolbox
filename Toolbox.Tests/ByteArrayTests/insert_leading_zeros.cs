using NUnit.Framework;

[TestFixture]
public partial class ByteArrayTests
{
    [TestCase(new byte[] { 0 }, 2, ExpectedResult = new byte[] { 0, 0 })]
    [TestCase(new byte[] { 5, 0, 15 }, 5, ExpectedResult = new byte[] { 0, 0, 5, 0, 15 })]
    public byte[] insert_leading_zeros(byte[] b, int length)
    {
        return Toolbox.ByteArray.InsertLeadingZeros(b, length);
    }

    [TestCase(new byte[] { 0 }, 0)]
    public void insert_leading_zeros_exception(byte[] b, int length)
    {
        Assert.Throws<System.ArgumentOutOfRangeException>(() => Toolbox.ByteArray.InsertLeadingZeros(b, length));
    }
}