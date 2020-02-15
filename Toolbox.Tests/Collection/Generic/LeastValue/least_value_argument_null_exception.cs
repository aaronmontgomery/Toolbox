using NUnit.Framework;

namespace Collection
{
    public static partial class Generic
    {
        [TestFixture]
        public static partial class LeastValue
        {
            [TestCase(null)]
            public static void least_value_argument_null_exception(int[] ints)
            {
                Assert.Throws<System.ArgumentNullException>(() => Toolbox.Collection.Generic.LeastValue(ints));
            }
        }
    }
}
