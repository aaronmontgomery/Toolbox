using NUnit.Framework;
using Toolbox;

namespace Numerical
{
    [TestFixture]
    public static partial class Random
    {
        [TestCase(5, 10)]
        public static void Random_WithXAndTolerance_XIsWithinTolerance(int x, int tolerance)
        {
            Assert.That(x.Random(tolerance).Between(x - tolerance, x + tolerance));
        }

        [TestCase(0, 0)]
        public static void Random_WithXZero_Zero(int x, int tolerance)
        {
            Assert.That(x.Random(tolerance) == 0);
        }

        [TestCase(10, 0)]
        public static void Random_WithToleranceZero_Ten(int x, int tolerance)
        {
            Assert.That(x.Random(tolerance) == 10);
        }
    }
}
