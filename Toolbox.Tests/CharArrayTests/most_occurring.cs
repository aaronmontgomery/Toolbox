using NUnit.Framework;
using Toolbox;

[TestFixture]
public partial class CharArrayTests
{
    [TestCase("abcc", ExpectedResult = new char[] { 'c' })]
    [TestCase("aaabbbcc", ExpectedResult = new char[] { 'a', 'b' })]
    [TestCase("1.9,8?0", ExpectedResult = new char[] { '1', '.', '9', ',', '8', '?', '0' })]
    public char[] most_occurring(string s)
    {
        return s.MostOccurring();
    }

    [TestCase("")]
    public void most_occurring_exception(string s)
    {
        Assert.Throws<System.InvalidOperationException>(() => Toolbox.CharArray.MostOccurring(s));
    }
}
