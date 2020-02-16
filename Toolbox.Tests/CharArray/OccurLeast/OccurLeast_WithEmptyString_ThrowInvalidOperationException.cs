using NUnit.Framework;

namespace CharArray
{
    [TestFixture]
    public static partial class OccurLeast
    {
        [TestCase("")]
        public static void OccurLeast_WithEmptyString_ThrowInvalidOperationException(string s)
        {
            Assert.Throws<System.InvalidOperationException>(() => Toolbox.CharArray.OccurLeast(s));
        }
    }
}
