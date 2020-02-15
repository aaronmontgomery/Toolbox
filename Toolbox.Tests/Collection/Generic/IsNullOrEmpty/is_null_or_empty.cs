using NUnit.Framework;
using Toolbox.Collection;

namespace Collection
{
    public static partial class Generic
    {
        [TestFixture]
        public static partial class IsNullOrEmpty
        {
            [TestCase(null, ExpectedResult = true)]
            [TestCase(new byte[] { }, ExpectedResult = true)]
            [TestCase(new byte[] { 0 }, ExpectedResult = false)]
            public static bool is_null_or_empty(byte[] collection)
            {
                return collection.IsNullOrEmpty();
            }
        }
    }
}
