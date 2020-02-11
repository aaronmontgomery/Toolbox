using NUnit.Framework;
using Toolbox.Collection;

[TestFixture]
public partial class CollectionTests
{
    public partial class GenericTests
    {
        [TestCase(new int[] { 0, 0 }, ExpectedResult = 0)]
        [TestCase(new int[] { -2, 1, 0, 5 }, ExpectedResult = -2)]
        [TestCase(new int[] { 5, -2, -3, 0, 1 }, ExpectedResult = -3)]
        public int least(int[] ints)
        {
            return ints.Least();
        }

        [TestCase(null)]
        public void least_exception(int[] ints)
        {
            Assert.Throws<System.ArgumentNullException>(() => Generic.Least(ints));
        }
    }
}
