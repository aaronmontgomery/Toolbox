using NUnit.Framework;
using Toolbox.Collection;

namespace Collection
{
    public static partial class Generic
    {
        [TestFixture]
        public static partial class IsNullOrEmpty
        {
            [TestCase(new byte[] { }, ExpectedResult =true)]
            public static bool IsNullOrEmpty_WithEmptyByteArray_True(byte[] collection)
            {
                return collection.IsNullOrEmpty();
            }
        }
    }
}
