namespace UnitTestProject.UnitTests.CustomerController.Tests;
using UnitTestingProject;

public class CustomerController_Tests
{
    private CustomerController _customerController;
    [SetUp]
    public void SetUp()
    {
        _customerController = new CustomerController();
    }
    
    [Test]
    public void GetCustomer_WhenIdIsZero_ReturnTypeNotFound()
    {
        var result = _customerController.GetCustomer(0);
        
        Assert.That(result, Is.TypeOf<CustomerController.NotFound>());
        Assert.That(result, Is.InstanceOf<CustomerController.NotFound>());
    }

    [Test]
    public void GetCustomer_WhenCalled_ReturnTypeOk()
    {
        var result = _customerController.GetCustomer(2);
        
        Assert.That(result, Is.TypeOf<CustomerController.Ok>());
        Assert.That(result, Is.InstanceOf<CustomerController.Ok>());
    }
}