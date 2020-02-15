using NUnit.Framework;

namespace Collection
{
    public static partial class Generic
    {
        [TestFixture]
        public static partial class LeastValue
        {
            [TestCase(new int[] { 0, 0 }, ExpectedResult = 0)]
            [TestCase(new int[] { -2, 1, 0, 5 }, ExpectedResult = -2)]
            [TestCase(new int[] { 5, -2, -3, 0, 1 }, ExpectedResult = -3)]
            public static int least_value(int[] ints)
            {
                return Toolbox.Collection.Generic.LeastValue(ints);
            }
        }
    }
}
