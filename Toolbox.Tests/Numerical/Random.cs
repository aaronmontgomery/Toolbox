using NUnit.Framework;
using Toolbox;

namespace Numerical
{
    [TestFixture]
    public static partial class Random
    {
        [TestCase(5, 10)]
        public static void Random_WithXAndRange_TrueXIsWithinRange(int x, int range)
        {
            Assert.That(x.Random(range).Between(x - range, x + range));
        }

        [TestCase(0, 0)]
        public static void Random_WithXZero_TrueXIsZero(int x, int range)
        {
            Assert.That(x.Random(range) == 0);
        }

        [TestCase(10, 0)]
        public static void Random_WithRangeZero_TrueXIsTen(int x, int range)
        {
            Assert.That(x.Random(range) == 10);
        }
    }
}
