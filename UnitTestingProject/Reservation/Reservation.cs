namespace UnitTestingProject.Reservation;

public class Reservation
{
    private readonly User _user;

    public Reservation(User user)
    {
        _user = user;
    }

    public bool cancelReservation(User madeBy)
    {
        var reservationValidity = false;
        if (_user.userName == madeBy.userName)
        {
            reservationValidity = true;
        }
        else if (madeBy.userName == "admin")
        {
            reservationValidity = true;
        }

        return reservationValidity;
    }
}

public class User
{
    public string userName { get; set; }
}