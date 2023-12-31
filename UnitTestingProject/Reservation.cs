namespace UnitTestingProject;

public class Reservation
{
    private readonly User _user;

    public Reservation(User user)
    {
        _user = user;
    }

    public bool cancelReservation(User madeBy)
    {
        // var reservationValidity = false;
        // if (_user.userName == madeBy.userName)
        // {
        //     reservationValidity = true;
        // }
        // else if (madeBy.userName == "admin")
        // {
        //     reservationValidity = true;
        // }
        //
        // return reservationValidity;

        return madeBy.userName == _user.userName || madeBy.userName == "admin";
    }
}

public class User
{
    public string userName { get; set; }
}