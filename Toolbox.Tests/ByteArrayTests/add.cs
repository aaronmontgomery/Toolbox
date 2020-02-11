using NUnit.Framework;

[TestFixture]
public partial class ByteArrayTests
{
    [TestCase(new byte[] { 0 }, new byte[] { 0 }, new byte[] { 0 })]
    public void Add_ZeroByteArrays_True(byte[] byte1, byte[] byte2, byte[] result)
    {
        Assert.AreEqual(Toolbox.ByteArray.Add(byte1, byte2), result);
    }

    [TestCase(new byte[] { 0 }, new byte[] { 5 }, new byte[] { 5 })]
    [TestCase(new byte[] { 5 }, new byte[] { 5, 10 }, new byte[] { 5, 15 })]
    [TestCase(new byte[] { 5, 10 }, new byte[] { 10 }, new byte[] { 5, 20 })]
    public void Add_PositiveByteArrays_True(byte[] byte1, byte[] byte2, byte[] result)
    {
        Assert.AreEqual(Toolbox.ByteArray.Add(byte1, byte2), result);
    }

    [TestCase(new byte[] {  }, new byte[] { 0 })]
    public void Add_EmptyByteArray_ThrowNullReferenceException(byte[] byte1, byte[] byte2)
    {
        Assert.Throws<System.NullReferenceException>(() => Toolbox.ByteArray.Add(byte1, byte2));
    }
}
