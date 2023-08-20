using UnitTestingProject;

namespace UnitTestProject.UnitTests.FizzBuzz.Tests;
public class FizzBuzz_Tests
{
    private UnitTestingProject.FizzBuzz _fizzBuzz;

    [SetUp]
    public void SetUp()
    {
        _fizzBuzz = new UnitTestingProject.FizzBuzz();
    }

    [Test]
    public void GetOutput_InputDivisibleByThreeNFive_ReturnFizzBuzz()
    {
        var result = _fizzBuzz.GetOutput(15);
        
        Assert.That(result, Is.EqualTo("FizzBuzz").IgnoreCase);
    }

    [Test]
    public void GetOutput_InputDivisibleByThreeOnly_ReturnFizz()
    {
        var result = _fizzBuzz.GetOutput(6);
        
        Assert.That(result, Is.EqualTo("Fizz").IgnoreCase);
    }

    [Test]
    public void GetOutput_InputDivisibleByFiveOnly_ReturnBuzz()
    {
        var result = _fizzBuzz.GetOutput(10);
        
        Assert.That(result, Is.EqualTo("Buzz"));
    } 

    [Test]
    public void GetOutput_InputNotDivisibleByThreeOrFive_ReturnNumber()
    {
        var result = _fizzBuzz.GetOutput(23);
        
        Assert.That(result, Is.EqualTo("23"));
    }
}