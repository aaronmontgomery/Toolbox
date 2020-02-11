using NUnit.Framework;
using Toolbox.Collection;

public partial class CollectionTests
{

    [TestFixture]
    public partial class GenericTests
    {
        [TestCase(null, ExpectedResult = true)]
        [TestCase(new byte[] { }, ExpectedResult = true)]
        [TestCase(new byte[] { 0 }, ExpectedResult = false)]
        public bool IsNullOrEmpty(byte[] collection)
        {
            return collection.IsNullOrEmpty();
        }
    }
}
