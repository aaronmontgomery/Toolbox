using NUnit.Framework;
using Toolbox;

namespace Numerical
{
    [TestFixture]
    public static partial class Between
    {
        [TestCase(0, 0, 0)]
        [TestCase(int.MinValue, 0, int.MaxValue)]
        public static void Between_WithInt_False(int x, int min, int max)
        {
            Assert.IsFalse(x.Between(min, max));
        }

        //[TestCase(short.MinValue, short.MaxValue, 0)]
        [TestCase(0, int.MinValue, int.MaxValue)]
        //[TestCase(long.MinValue, long.MaxValue, 0)]
        //[TestCase(double.MinValue, double.MaxValue, 0)]
        public static void Between_WithInt_True(int x, int min, int max)
        {
            Assert.IsTrue(x.Between(min, max));
        }
    }
}
