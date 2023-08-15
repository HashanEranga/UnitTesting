using UnitTestingProject;

namespace UnitTestProject.UnitTests.Reservation.Tests;

public class Reservation_Tests
{
    [Test]
    public void cancelReservation_sameUserCancel_ReturnsTrue()
    {
        // Arrange
        var user = new User() { userName = "client" };
        var newReservation = new UnitTestingProject.Reservation(user);
        // Act
        var isReservationCancelled = newReservation.cancelReservation(user);
        // Assert
        Assert.IsTrue(isReservationCancelled);
    }

    [Test]
    public void cancelReservation_diffUserCancel_ReturnsFalse()
    {
        // Arrange
        var user = new User() { userName = "client" };
        var newReservation = new UnitTestingProject.Reservation(user);
        var otherUser = new User() { userName = "otherClient" };
        // Act 
        var isReservationCancelled = newReservation.cancelReservation(otherUser);
        // Assert
        Assert.IsFalse(isReservationCancelled);
    }

    [Test]
    public void cancelReservation_adminUserCancel_ReturnTrue()
    {
        // Arrange 
        var user = new User(){userName = "admin"};
        var newReservation = new UnitTestingProject.Reservation(user);
        // Act
        var isReservationCancelled = newReservation.cancelReservation(user);
        // Assert
        Assert.IsTrue(isReservationCancelled);
    }
}