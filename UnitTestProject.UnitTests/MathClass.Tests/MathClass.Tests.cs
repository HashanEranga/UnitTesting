namespace UnitTestProject.UnitTests.MathClass.Tests;
using UnitTestingProject;
public class MathClass_Tests
{
    private readonly MathClass _math = new();
    private int a, b;
    
    [Test]
    public void Add_WhenCalled_ReturnSumOfNumbers()
    {
        a = 23;
        b = 10;
        var results = _math.Add(a, b);
        Assert.AreEqual(a+b, results);
    }

    [Test]
    public void Max_WhenFirstArgumentLarger_ReturnFirstArgument()
    {
        a = 23;
        b = 10;
        var result = _math.Max(a, b);
        Assert.AreEqual(a,result);
    }

    [Test]
    public void Max_WhenSecondArgumentLarger_ReturnSecondArgument()
    {
        a = 23;
        b = 45;
        var result = _math.Max(a, b);
        Assert.AreEqual(b,result);
    }

    [Test]
    public void Max_WhenBothArgumentsAreSame_ReturnFirstArgument()
    {
        a = 67;
        b = 67;
        var result = _math.Max(a, b);
        Assert.AreEqual(a,result);
    }
}