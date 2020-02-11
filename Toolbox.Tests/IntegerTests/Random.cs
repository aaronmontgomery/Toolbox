using NUnit.Framework;
using Toolbox;

[TestFixture]
public partial class IntegerTests
{
    [TestCase(10, 0, ExpectedResult = 10)]
    [TestCase(null, null, ExpectedResult = 0)]
    public int Random(int i, int tolerance)
    {
        return i.Random(tolerance);
    }
}
