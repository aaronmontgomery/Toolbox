using NUnit.Framework;
using Toolbox;

namespace CharArray
{
    [TestFixture]
    public static partial class OccurMost
    {
        [TestCase("abcc", ExpectedResult =new char[] { 'c' })]
        [TestCase("aaabbbcc", ExpectedResult =new char[] { 'a', 'b' })]
        [TestCase("1.9,8?0", ExpectedResult =new char[] { '1', '.', '9', ',', '8', '?', '0' })]
        public static char[] OccurMost_WithCharsInString_GetMostOccurringChar(string s)
        {
            return s.OccurMost();
        }
    }
}
