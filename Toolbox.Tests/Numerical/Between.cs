using NUnit.Framework;
using Toolbox;

namespace Numerical
{
    [TestFixture]
    public static partial class Between
    {
        [TestCase(0, 0, 0)]
        [TestCase(int.MinValue, 0, int.MaxValue)]
        public static void Between_WithInt_FalseXIsNotBetweenMinAndMax(int x, int min, int max)
        {
            Assert.IsFalse(x.Between(min, max));
        }
        
        [TestCase(0, int.MinValue, int.MaxValue)]
        public static void Between_WithInt_TrueXIsBetweenMinAndMax(int x, int min, int max)
        {
            Assert.IsTrue(x.Between(min, max));
        }
    }
}
