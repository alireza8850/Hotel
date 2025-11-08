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
        bool Found = false;

        while (i < _rooms.Count)
        {
            Room room_i = _rooms[i];
            if (room_i.Status == RoomStatus.Occupied)
            {
                Console.WriteLine(room_i.ToString());
                Found = true;

            }
            i = i + 1;
        }
        if (!Found)
        {
            Console.WriteLine();
            Console.WriteLine("Inga upptagna rum.");
        }    
            Console.WriteLine();
            Console.WriteLine("Tryck Enter för att fortsätta.");
            Console.ReadLine();
        
    }

    public void Available()
    {
        Console.WriteLine("Lediga rum: ");
        bool Found = false;
        int i = 0;
        while (i < _rooms.Count)
        {
            Room room_i = _rooms[i];
            if (room_i.Status == RoomStatus.Empty)
            {
                Console.WriteLine(room_i.ToString());
                Found = true;

            }
            i = i + 1;

        }
        if (!Found)
        {
            Console.WriteLine();
            Console.WriteLine("Inga lediga rum.");
        }    
            Console.WriteLine();
            Console.WriteLine("Tryck Enter för att fortsätta.");
            Console.ReadLine();
        

    }



}