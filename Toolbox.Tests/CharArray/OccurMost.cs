using NUnit.Framework;
using Toolbox;

namespace CharArray
{
    [TestFixture]
    public static partial class OccurMost
    {
        [TestCase("abcc", ExpectedResult = new char[] { 'c' })]
        [TestCase("aaabbbcc", ExpectedResult = new char[] { 'a', 'b' })]
        [TestCase("1.9,8?0", ExpectedResult = new char[] { '1', '.', '9', ',', '8', '?', '0' })]
        public static char[] OccurMost_WithString_GetMostOccurringChar(string s)
        {
            return s.OccurMost();
        }

        [TestCase("")]
        public static void OccurMost_WithEmpty_ThrowsArgumentException(string s)
        {
            Assert.Throws<System.ArgumentException>(() => s.OccurMost());
        }

        [TestCase(null)]
        public static void OccurMost_WithNull_ThrowsArgumentNullException(string s)
        {
            Assert.Throws<System.ArgumentNullException>(() => s.OccurMost());
        }
    }
}
