using NUnit.Framework;

[TestFixture]
public partial class ByteArrayTests
{
    [TestCase(new byte[] { 0 }, 2, ExpectedResult = new byte[] { 0, 0 })]
    [TestCase(new byte[] { 5, 0, 15 }, 5, ExpectedResult = new byte[] { 5, 0, 15, 0, 0 })]
    public byte[] insert_trailing_zeros(byte[] b, int length)
    {
        return Toolbox.ByteArray.InsertTrailingZeros(b, length);
    }

    [TestCase(new byte[] { 0 }, 0)]
    public void insert_trailing_zeros_exception(byte[] b, int length)
    {
        Assert.Throws<System.ArgumentException>(() => Toolbox.ByteArray.InsertTrailingZeros(b, length));
    }
}