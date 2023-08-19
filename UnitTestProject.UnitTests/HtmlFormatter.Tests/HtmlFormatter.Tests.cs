namespace UnitTestProject.UnitTests.HtmlFormatter.Tests;
using UnitTestingProject;

public class HtmlFormatter_Tests
{
    private HtmlFormatter _htmlFormatter;
    [SetUp]
    public void SetUp()
    {
        _htmlFormatter = new HtmlFormatter();
    }
    [Test]
    public void FormatAsBold_WhenCalled_ShouldEncloseWithStrongTags()
    {
        var results = _htmlFormatter.FormatAsBold("Hashan");
        
        // specific
        Assert.That(results,Is.EqualTo("<strong>Hashan</strong>").IgnoreCase);
        
        // general 
        Assert.That(results, Does.StartWith("<strong>").IgnoreCase);
        Assert.That(results, Does.EndWith("</strong>").IgnoreCase);
        Assert.That(results, Does.Contain("Hashan").IgnoreCase);
    } 
}