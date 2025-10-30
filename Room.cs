namespace App;


public class Room
{
    // vi behöver rumnummer, om det är tillgänligt eller inte och vem bor i rummet för tillfället
    public int Number;
    public RoomStatus Status;
    public string GuestName;

    public Room(int number, RoomStatus status, string guestname)
    {
        Number = number;
        Status = status;
        GuestName = guestname;
    }

}