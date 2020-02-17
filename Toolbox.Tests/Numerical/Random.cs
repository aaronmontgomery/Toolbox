using NUnit.Framework;
using Toolbox;

namespace Numerical
{
    [TestFixture]
    public static partial class Random
    {
        [TestCase(0, 0, ExpectedResult = 0)]
        public static int Random_WithXZero_Zero(int x, int tolerance)
        {
            return x.Random(tolerance);
        }

        [TestCase(10, 0, ExpectedResult = 10)]
        public static int Random_WithToleranceZero_Ten(int x, int tolerance)
        {
            return x.Random(tolerance);
        }
    }
}
