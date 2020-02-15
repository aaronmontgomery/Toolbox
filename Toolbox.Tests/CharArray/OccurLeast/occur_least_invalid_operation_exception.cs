using NUnit.Framework;

namespace CharArray
{
    [TestFixture]
    public static partial class OccurLeast
    {
        [TestCase("")]
        public static void occur_least_invalid_operation_exception(string s)
        {
            Assert.Throws<System.InvalidOperationException>(() => Toolbox.CharArray.OccurLeast(s));
        }
    }
}
