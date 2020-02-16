using NUnit.Framework;
using Toolbox;

namespace Integer
{
    [TestFixture]
    public static partial class Random
    {
        [TestCase(10, 0, ExpectedResult =10)]
        public static int Random_WithIntInt_Ten(int i, int tolerance)
        {
            return i.Random(tolerance);
        }
    }
}
