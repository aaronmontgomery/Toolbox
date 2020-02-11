using NUnit.Framework;

[TestFixture]
public partial class DatabaseTests
{
    [TestCase("", "", ExpectedResult = true)]
    public bool CreateFile(string schemaPath, string databasePath)
    {
        string schemaFilePath = @"C:\Users\aaron.montgomery\Google Drive\Dev\Database\Data\";
        string schemaFileName = "schema.json";
        string databaseFilePath = @"C:\Users\aaron.montgomery\Google Drive\Dev\Database\Data\";
        string databaseFileName = "data.json";
        Toolbox.Database.Create.File(schemaFilePath + schemaFileName, databaseFilePath + databaseFileName);
        return false;
    }
}
