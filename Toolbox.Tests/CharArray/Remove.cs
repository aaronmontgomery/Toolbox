using System;
using NUnit.Framework;
using Toolbox;

namespace CharArray
{
    [TestFixture]
    public static class Remove
    {
        [TestCase("abcc", new char[] { 'a' }, ExpectedResult = "bcc")]
        [TestCase("aaabbbcc", new char[] { 'b' }, ExpectedResult = "aaacc")]
        [TestCase("1@9=2%8", new char[] { '=' }, ExpectedResult = "1@92%8")]
        public static string Remove_WithStringAndCharArray_StringWithCharactersRemoved(string s, char[] charsToRemove)
        {
            return s.Remove(charsToRemove);
        }

        [TestCase("aaa", new char[] { 'b' }, ExpectedResult = "aaa")]
        [TestCase("aaa", new char[] { 'b', 'c' }, ExpectedResult = "aaa")]
        public static string Remove_WithCharNotFound_StringUnmodified(string s, char[] charsToRemove)
        {
            return s.Remove(charsToRemove);
        }

        [TestCase("", new char[] { 'a' }, ExpectedResult = "")]
        [TestCase("a", new char[] { }, ExpectedResult = "a")]
        public static string Remove_WithEmpty_StringUnmodified(string s, char[] charsToRemove)
        {
            return s.Remove(charsToRemove);
        }

        [TestCase(null, new char[] { })]
        [TestCase("", null)]
        [TestCase(null, null)]
        public static void Remove_WithNull_ThrowsArgumentNullException(string s, char[] charsToRemove)
        {
            Assert.Throws<ArgumentNullException>(() => s.Remove(charsToRemove));
        }
    }
}
