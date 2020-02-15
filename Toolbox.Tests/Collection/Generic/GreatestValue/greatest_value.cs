using NUnit.Framework;

namespace Collection
{
    public static partial class Generic
    {
        [TestFixture]
        public static partial class GreatestValue
        {
            [TestCase(new int[] { 0, 0 }, ExpectedResult = 0)]
            [TestCase(new int[] { -2, 1, 0, 5 }, ExpectedResult = 5)]
            [TestCase(new int[] { 5, -2, -3, 0, 1 }, ExpectedResult = 5)]
            public static int greatest_value(int[] ints)
            {
                return Toolbox.Collection.Generic.GreatestValue(ints);
            }
        }
    }
}
