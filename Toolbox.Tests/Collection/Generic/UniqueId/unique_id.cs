using NUnit.Framework;

namespace Collection
{
    public static partial class Generic
    {
        [TestFixture]
        public static partial class UniqueId
        {
            [TestCase(new int[] { 0, 0 }, ExpectedResult = true)]
            public static bool unique_id(dynamic collection)
            {
                return false;
            }
        }
    }
}
