using NUnit.Framework;
using Toolbox;

namespace Integer
{
    [TestFixture]
    public static partial class Between
    {
        [TestCase(-1, 5, 10, ExpectedResult = false)]
        [TestCase(0, 0, 0, ExpectedResult = false)]
        [TestCase(1, 10, 5, ExpectedResult = false)]
        public static bool Between_WithIntInt_False(int integer, int x, int y)
        {
            return integer.Between(x, y);
        }
    }
}
