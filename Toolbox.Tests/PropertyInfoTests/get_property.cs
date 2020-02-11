using NUnit.Framework;

[TestFixture]
public partial class CollectionTests
{
    public partial class GenericTests
    {
        [TestCase(ExpectedResult = true)]
        public bool get_property()
        {
            return false;
        }
    }
}
