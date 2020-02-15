using NUnit.Framework;

namespace Cryptography
{
    public static partial class Sha512
    {
        [TestFixture]
        public static partial class GenerateSalt
        {
            [TestCase(ExpectedResult = true)]
            public static bool generate_salt()
            {
                return false;
            }
        }
    }
}
