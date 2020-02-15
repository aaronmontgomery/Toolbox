using NUnit.Framework;

namespace Collection
{
    public static partial class Generic
    {
        [TestFixture]
        public static partial class Least
        {
            [TestCase(null)]
            public static void least_argument_null_exception(int[] ints)
            {
                Assert.Throws<System.ArgumentNullException>(() => Toolbox.Collection.Generic.Least(ints));
            }
        }
    }
}
