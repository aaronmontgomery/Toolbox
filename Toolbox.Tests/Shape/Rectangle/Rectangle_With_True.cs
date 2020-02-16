using NUnit.Framework;

namespace Shape
{
    [TestFixture]
    public static partial class Rectangle
    {
        [TestCase(ExpectedResult =true)]
        public static bool Rectangle_With_True()
        {
            return false;
        }
    }
}
