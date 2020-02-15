using NUnit.Framework;

namespace Cryptography
{
    public static partial class Sha512
    {
        [TestFixture]
        public static partial class GenerateHash
        {
            [TestCase(ExpectedResult = true)]
            public static bool generate_hash()
            {
                return false;
            }
        }
    }
}
