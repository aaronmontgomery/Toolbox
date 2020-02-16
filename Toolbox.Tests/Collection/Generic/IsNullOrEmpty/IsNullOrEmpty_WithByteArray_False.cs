using NUnit.Framework;
using Toolbox.Collection;

namespace Collection
{
    public static partial class Generic
    {
        [TestFixture]
        public static partial class IsNullOrEmpty
        {
            [TestCase(new byte[] { 0 }, ExpectedResult =false)]
            public static bool IsNullOrEmpty_WithByteArray_False(byte[] collection)
            {
                return collection.IsNullOrEmpty();
            }
        }
    }
}
