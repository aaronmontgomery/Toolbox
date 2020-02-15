using NUnit.Framework;

namespace File
{
    public static partial class M3u
    {
        [TestFixture]
        public static partial class FileLine
        {
            [TestCase(ExpectedResult = true)]
            public static bool file_line()
            {
                return false;
            }
        }
    }
}
