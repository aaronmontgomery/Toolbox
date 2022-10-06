using NUnit.Framework;

namespace Cryptography
{
    public static partial class Sha512
    {
        [TestFixture]
        public static partial class Hash
        {
            [TestCase()]
            public static void Hash_WithString_Pass()
            {
                Assert.Pass();
            }
        }
    }
}
