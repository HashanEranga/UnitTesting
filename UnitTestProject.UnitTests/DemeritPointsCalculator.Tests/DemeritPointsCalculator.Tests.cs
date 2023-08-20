namespace UnitTestProject.UnitTests.DemeritPointsCalculator.Tests;

public class DemeritPointsCalculator_Tests
{
    private UnitTestingProject.DemeritPointsCalculator _demeritPointsCalculator;

    [SetUp]
    public void SetUp()
    {
        _demeritPointsCalculator = new UnitTestingProject.DemeritPointsCalculator();
    }

    [Test]
    [TestCase(-23)]
    public void CalculateDemeritPoints_SpeedLimitOutOfRange_ThrowsArgumentOutOfRangeException(int num)
    {
        Assert.That(()=> _demeritPointsCalculator.CalculateDemeritPoints(num), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
    }

    [Test]
    [TestCase(12)]
    [TestCase(65)]
    public void CalculateDemeritPoints_LowerThanSpeedLimit_ReturnZero(int num)
    {
        Assert.That(_demeritPointsCalculator.CalculateDemeritPoints(num), Is.EqualTo(0));
    }

    [Test]
    [TestCase(100, 7)]
    [TestCase(90, 5)]
    public void CalculateDemeritPoints_HigherThan_ReturnDemeritPoints(int num, int expectedResult)
    {
        Assert.That(_demeritPointsCalculator.CalculateDemeritPoints(num), Is.EqualTo(expectedResult));
    }
}