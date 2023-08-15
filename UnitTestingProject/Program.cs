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

