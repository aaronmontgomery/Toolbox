using NUnit.Framework;

[TestFixture]
public partial class CollectionTests
{
    public partial class GenericTests
    {
        [TestCase(new int[] { 0, 0 }, ExpectedResult = true)]
        public bool unique_id(dynamic collection)
        {
            return false;
        }
    }
}
