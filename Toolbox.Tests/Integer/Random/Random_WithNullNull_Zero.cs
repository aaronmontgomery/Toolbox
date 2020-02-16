using NUnit.Framework;
using Toolbox;

namespace Integer
{
    [TestFixture]
    public static partial class Random
    {
        [TestCase(null, null, ExpectedResult =0)]
        public static int Random_WithNullNull_Zero(int i, int tolerance)
        {
            return i.Random(tolerance);
        }
    }
}
