using NUnit.Framework;

public partial class CollectionTests
{

    [TestFixture]
    public partial class GenericTests
    {
        [TestCase(new int[] { 0, 0 }, ExpectedResult = 0)]
        [TestCase(new int[] { -2, 1, 0, 5 }, ExpectedResult = 5)]
        [TestCase(new int[] { 5, -2, -3, 0, 1 }, ExpectedResult = 5)]
        public int greatest_value(int[] ints)
        {
            return Toolbox.Collection.Generic.GreatestValue(ints);
        }

        [TestCase(null)]
        public void greatest_value_exception(int[] ints)
        {
            Assert.Throws<System.ArgumentNullException>(() => Toolbox.Collection.Generic.GreatestValue(ints));
        }
    }
}
