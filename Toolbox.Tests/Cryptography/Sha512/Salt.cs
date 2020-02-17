using NUnit.Framework;

namespace Cryptography
{
    public static partial class Sha512
    {
        [TestFixture]
        public static partial class Salt
        {
            [TestCase()]
            public static void Salt_With_Pass()
            {
                Assert.Pass();
            }
        }
    }
}
