using NUnit.Framework;

namespace Web
{
    [TestFixture]
    public static partial class SendWebRequest
    {
        [TestCase(ExpectedResult =true)]
        public static bool SendWebRequest_With_True()
        {
            return false;
        }
    }
}
