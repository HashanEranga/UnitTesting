using UnitTestingProject;

Console.WriteLine("Hello, World!");

// sample application how reservation class is used
var user = new User(){userName = "client"};
var newReservation = new Reservation(user);

var isReservationCancelled = newReservation.cancelReservation(user);
Console.WriteLine(isReservationCancelled);

var otherUser = new User();
isReservationCancelled = newReservation.cancelReservation(otherUser);
Console.WriteLine(isReservationCancelled);

var adminUser = new User() { userName = "admin" };
isReservationCancelled = newReservation.cancelReservation(adminUser);
Console.WriteLine(isReservationCancelled);

// Checking math.cs
var math = new MathClass();
int a = 12, b = 10;

Console.WriteLine($"Addition of {a} and {b} is : {math.Add(a,b)}");
Console.WriteLine($"Maximum value of {a} and {b} is : {math.Max(a,b)}");
Console.WriteLine(math.GetAllOddNumbers(40));
foreach (var item in math.GetAllOddNumbers(40))
{
    Console.WriteLine(item);
}

// Checking HtmlFormatter.cs
var htmlFormatter = new HtmlFormatter();
Console.WriteLine(htmlFormatter.FormatAsBold("Hashan"));
