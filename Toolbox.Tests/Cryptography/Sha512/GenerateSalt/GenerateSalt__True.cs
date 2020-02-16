using NUnit.Framework;

namespace Cryptography
{
    public static partial class Sha512
    {
        [TestFixture]
        public static partial class GenerateSalt
        {
            [TestCase(ExpectedResult =true)]
            public static bool GenerateSalt__True()
            {
                return false;
            }
        }
    }
}
