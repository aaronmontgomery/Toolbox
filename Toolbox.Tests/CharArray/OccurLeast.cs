using System;
using NUnit.Framework;
using Toolbox;

namespace CharArray
{
    [TestFixture]
    public static partial class OccurLeast
    {
        [TestCase("abcc", ExpectedResult = new char[] { 'a', 'b' })]
        [TestCase("aaabbbcc", ExpectedResult = new char[] { 'c' })]
        [TestCase("1@9=2%8", ExpectedResult = new char[] { '1', '@', '9', '=', '2', '%', '8' })]
        public static char[] OccurLeast_WithStringAndCharArray_GetLeastOccurringChar(string s)
        {
            return s.OccurLeast();
        }

        [TestCase("")]
        public static void OccurLeast_WithEmpty_ThrowsArgumentException(string s)
        {
            Assert.Throws<ArgumentException>(() => s.OccurLeast());
        }

        [TestCase(null)]
        public static void OccurLeast_WithNull_ThrowsArgumentNullException(string s)
        {
            Assert.Throws<ArgumentNullException>(() => s.OccurLeast());
        }
    }
}
