using NUnit.Framework;
using Toolbox;

[TestFixture]
public partial class ByteArrayTests
{
    [TestCase(new byte[] { 3 }, ExpectedResult = new byte[] { 252 })]
    [TestCase(new byte[] { 5, 10 }, ExpectedResult = new byte[] { 250, 245 })]
    public byte[] not(byte[] b)
    {
        return b.Not();
    }
}