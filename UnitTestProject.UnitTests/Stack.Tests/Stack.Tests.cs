using UnitTestingProject;

namespace UnitTestProject.UnitTests.Stack.Tests;

public class Stack_Tests
{
    private StackDS<string> _stackDs;
    [SetUp]
    public void SetUp()
    {
        _stackDs = new StackDS<string>();
    }

    [Test]
    [TestCase(null)]
    public void Push_WhenCalledWithNullObject_ThrowArgumentNullException(string item)
    {
        Assert.That(()=> _stackDs.Push(item), Throws.Exception.TypeOf<ArgumentNullException>());
    }

    [Test]
    [TestCase("a")]
    public void Push_WhenCalledWithNotNull_AddObjToList(string item)
    {
        _stackDs.Push(item);
        Assert.That(_stackDs.Count, Is.EqualTo(1));
    }

    [Test]
    public void Pop_WhenCalledToAnEmptyStack_ThrowInvalidOperationException()
    {
        Assert.That(()=>_stackDs.Pop(), Throws.Exception.TypeOf<InvalidOperationException>());
    }

    [Test]
    public void Pop_WhenCalledNonEmptyList_ReturnLastElementWithLessElementOnTheList()
    {
        _stackDs.Push("item1");
        _stackDs.Push("item2");
        _stackDs.Push("item3");
        _stackDs.Push("item4");

        var result = _stackDs.Pop();
        Assert.That(result, Is.EqualTo("item4"));
        Assert.That(_stackDs.Count, Is.EqualTo(3));
    }

    [Test]
    public void Peek_WhenCalledToAnEmptyStack_ThrowInvalidOperationException()
    {
        Assert.That(()=>_stackDs.Peek(), Throws.Exception.TypeOf<InvalidOperationException>());
    }

    [Test]
    public void Peek_WhenCalledToAnNonEmptyStack_ReturnLastElementWithoutReducingTheNumberOfElements()
    {
        _stackDs.Push("item1");
        _stackDs.Push("item2");
        _stackDs.Push("item3");
        _stackDs.Push("item4");

        var result = _stackDs.Peek();
        Assert.That(result, Is.EqualTo("item4"));
        Assert.That(_stackDs.Count, Is.EqualTo(4));
    }
}