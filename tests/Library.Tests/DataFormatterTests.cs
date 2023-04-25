namespace TestDateFormat;

public class DateFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestWrongDate()
    {
        const string Input = "25/11/1999";
        const string Expected = "1999-11-25";

        string actual = DateFormatter.ChangeFormat(Input);
        Assert.That(actual, Is.EqualTo(Expected));
    }

    [Test]
    public void TestWrongMonth()
    {
        const string Input = "11/25/1999";
        const string Expected = "";

        string actual = DateFormatter.ChangeFormat(Input);
        Assert.That(actual, Is.EqualTo(Expected));
    }

    [Test]
    public void TestWrongYear()
    {
        const string Input = "";
        const string Expected = "";

        string actual = DateFormatter.ChangeFormat(Input);
        Assert.That(actual, Is.EqualTo(Expected));
    }
}