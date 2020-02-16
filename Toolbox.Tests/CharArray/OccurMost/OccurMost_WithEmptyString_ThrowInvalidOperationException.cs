using NUnit.Framework;

namespace CharArray
{
    [TestFixture]
    public static partial class OccurMost
    {
        [TestCase("")]
        public static void OccurMost_WithEmptyString_ThrowInvalidOperationException(string s)
        {
            Assert.Throws<System.InvalidOperationException>(() => Toolbox.CharArray.OccurMost(s));
        }
    }
}
