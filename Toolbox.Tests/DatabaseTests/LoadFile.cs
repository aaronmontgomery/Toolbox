using NUnit.Framework;

[TestFixture]
public partial class DatabaseTests
{
    [TestCase("", "", ExpectedResult = true)]
    public bool LoadFile(string schemaPath, string databasePath)
    {
        return false;
    }
}
