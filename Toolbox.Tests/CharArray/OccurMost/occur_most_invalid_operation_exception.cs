using NUnit.Framework;

namespace CharArray
{
    [TestFixture]
    public static partial class OccurMost
    {
        [TestCase("")]
        public static void occur_most_invalid_operation_exception(string s)
        {
            Assert.Throws<System.InvalidOperationException>(() => Toolbox.CharArray.OccurMost(s));
        }
    }
}
