namespace UnitTestingProject;

public class CustomerController
{
    public ActionResult GetCustomer(int id)
    {
        return (id == 0) ? new NotFound() : new Ok();
    }
    public class ActionResult {}
    public class NotFound : ActionResult {}
    public class Ok : ActionResult {}
}