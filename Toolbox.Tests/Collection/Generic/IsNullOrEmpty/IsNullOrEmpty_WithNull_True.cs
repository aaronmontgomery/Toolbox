using NUnit.Framework;
using Toolbox.Collection;

namespace Collection
{
    public static partial class Generic
    {
        [TestFixture]
        public static partial class IsNullOrEmpty
        {
            [TestCase(null, ExpectedResult =true)]
            public static bool IsNullOrEmpty_WithNull_True(byte[] collection)
            {
                return collection.IsNullOrEmpty();
            }
        }
    }
}
