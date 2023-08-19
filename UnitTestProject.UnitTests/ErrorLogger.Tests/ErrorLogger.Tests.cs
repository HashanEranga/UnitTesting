namespace UnitTestProject.UnitTests.ErrorLogger.Tests;
using UnitTestingProject;

public class ErrorLogger_Tests
{
    private ErrorLogger _errorLogger;
    [SetUp]
    public void Setup()
    {
        _errorLogger = new ErrorLogger();
    }

    [Test]
    public void Log_WhenCalled_SetTheLastErrorProperty()
    {
        _errorLogger.Log("sample error");
        
        Assert.That(_errorLogger.LastError, Is.EqualTo("sample error"));
    }

    [Test]
    [TestCase(null)]
    [TestCase("")]
    [TestCase(" ")]
    public void Log_InvalidLogger_ThrowArgumentNullException(string error)
    {
        Assert.That(()=> _errorLogger.Log(error), Throws.ArgumentNullException);
        Assert.That(()=> _errorLogger.Log(error), Throws.Exception.TypeOf<ArgumentNullException>());
    }
}