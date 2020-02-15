using NUnit.Framework;
using Toolbox;

namespace Integer
{
    [TestFixture]
    public static partial class Random
    {
        [TestCase(10, 0, ExpectedResult = 10)]
        [TestCase(null, null, ExpectedResult = 0)]
        public static int random(int i, int tolerance)
        {
            return i.Random(tolerance);
        }
    }
}
