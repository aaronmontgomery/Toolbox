using NUnit.Framework;
using Toolbox;

namespace Integer
{
    [TestFixture]
    public static partial class Between
    {
        [TestCase(0, 0, 0, ExpectedResult = false)]
        [TestCase(5, -1, 10, ExpectedResult = true)]
        [TestCase(-1, 5, 10, ExpectedResult = false)]
        [TestCase(1, 10, 5, ExpectedResult = false)]
        public static bool between(int integer, int x, int y)
        {
            return integer.Between(x, y);
        }
    }
}
