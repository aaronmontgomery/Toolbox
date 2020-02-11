using NUnit.Framework;
using Toolbox;

[TestFixture]
public partial class CharArrayTests
{
    [TestCase("abcc", ExpectedResult = new char[] { 'a', 'b' })]
    [TestCase("aaabbbcc", ExpectedResult = new char[] { 'c' })]
    [TestCase("1.9,8?0", ExpectedResult = new char[] { '1', '.', '9', ',', '8', '?', '0' })]
    public char[] least_occurring(string s)
    {
        return s.LeastOccurring();
    }

    [TestCase("")]
    public void least_occurring_exception(string s)
    {
        Assert.Throws<System.InvalidOperationException>(() => Toolbox.CharArray.LeastOccurring(s));
    }
}
