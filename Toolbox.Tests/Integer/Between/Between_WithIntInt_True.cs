using NUnit.Framework;
using Toolbox;

namespace Integer
{
    [TestFixture]
    public static partial class Between
    {
        [TestCase(5, -1, 10, ExpectedResult =true)]
        public static bool Between_WithIntInt_True(int integer, int x, int y)
        {
            return integer.Between(x, y);
        }
    }
}
