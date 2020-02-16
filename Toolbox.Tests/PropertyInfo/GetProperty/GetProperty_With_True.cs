using NUnit.Framework;

namespace PropertyInfo
{
    [TestFixture]
    public static partial class GetProperty
    {
        [TestCase(ExpectedResult =true)]
        public static bool GetProperty_With_True()
        {
            return false;
        }
    }
}
