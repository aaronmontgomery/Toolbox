using NUnit.Framework;

namespace Collection
{
    public static partial class Generic
    {
        [TestFixture]
        public static partial class GreatestValue
        {
            [TestCase(null)]
            public static void greatest_value_argument_null_exception(int[] ints)
            {
                Assert.Throws<System.ArgumentNullException>(() => Toolbox.Collection.Generic.GreatestValue(ints));
            }
        }
    }
}
