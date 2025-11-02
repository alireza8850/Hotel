namespace App;

public class Reception
{
    private List<Room> _rooms = new List<Room>();
    public Reception(List<Room> rooms)
    {
        _rooms = rooms;
    }

    public void ShowOccupiedRooms()
    {
        Console.WriteLine("Alla upptagna rum: ");

        int i = 0;
        
        while (i<_rooms.Count)
        {
            Room room_i = _rooms[i];
            if (room_i.Status == RoomStatus.Occupied)
            {
                Console.WriteLine(room_i.ToString());

            }
            i = i + 1;
        }
    }
}