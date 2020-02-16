using NUnit.Framework;
using Toolbox;

namespace CharArray
{
    [TestFixture]
    public static partial class OccurLeast
    {
        [TestCase("abcc", ExpectedResult =new char[] { 'a', 'b' })]
        [TestCase("aaabbbcc", ExpectedResult =new char[] { 'c' })]
        [TestCase("1.9,8?0", ExpectedResult =new char[] { '1', '.', '9', ',', '8', '?', '0' })]
        public static char[] OccurLeast_WithCharsInString_GetLeastOccurringChar(string s)
        {
            return s.OccurLeast();
        }
    }
}
