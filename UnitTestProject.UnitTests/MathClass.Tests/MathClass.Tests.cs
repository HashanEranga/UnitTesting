namespace UnitTestProject.UnitTests.MathClass.Tests;
using UnitTestingProject;
public class MathClass_Tests
{
    private MathClass _math;
    private int a, b;

    [SetUp]
    public void SetUp()
    {
        _math = new MathClass();
        a = 0;
        b = 0;
    }
    
    [Test]
    public void Add_WhenCalled_ReturnSumOfNumbers()
    {
        a = 23;
        b = 10;
        var results = _math.Add(a, b);
        Assert.AreEqual(a+b, results);
    }

    [Test]
    [TestCase(2,1,2)]
    [TestCase(1,2,2)]
    [TestCase(2,2,2)]
    public void Max_WhenGreaterArgumentGiven_ReturnGreaterArgument(int a, int b, int expectedResult)
    {
        var results = _math.Max(a, b);
        Assert.AreEqual(expectedResult, results);
    }

    [Test]
    public void GetAllOddNumbers_LimitsGreaterThanZero_ReturnOddNumbersUptoLimit()
    {
        var result = _math.GetAllOddNumbers(5);
        Assert.That(result, Is.Not.Empty);
        Assert.That(result.Count(), Is.EqualTo(3));
        Assert.That(result, Does.Contain(1));
        Assert.That(result, Does.Contain(3));
        Assert.That(result, Does.Contain(5));
        Assert.That(result, Is.EquivalentTo(new []{1,3,5}));
        Assert.That(result, Is.Ordered);
        Assert.That(result, Is.Unique);
    }
}