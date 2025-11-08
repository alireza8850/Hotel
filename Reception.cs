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

    public void Available()   // metoden för att visa lediga rum
    {
        Console.WriteLine("Lediga rum: ");
        bool Found = false;                 // en flagga för att kolla om vi hittat lediga rum
        int i = 0;
        while (i < _rooms.Count)
        {
            Room room_i = _rooms[i];
            if (room_i.Status == RoomStatus.Empty)   // kontrollera om rummet är Empty
            {
                Console.WriteLine(room_i.ToString());  //om rummet är ledig skriv ut information
                Found = true;                          // hittad

            }
            i = i + 1;                              // nästa

        }
        if (!Found)                 //om fortfarande false skriv ut detta
        {
            Console.WriteLine();
            Console.WriteLine("Inga lediga rum.");
        }
        Console.WriteLine();
        Console.WriteLine("Tryck Enter för att fortsätta.");
        Console.ReadLine();
    }
    public bool BookIn(int RoomNumber, string guestname) // returnerar true om bokningen lyckas och false om den misslyckas
    {
        int i = 0;
        while (i < _rooms.Count)                // Loopar genom så länge vi inte nåt slutet av rumlistan
        {
            Room room_i = _rooms[i];
            
            if (room_i.Number == RoomNumber)    // kontrollera om det rätt rum
            {
                if (room_i.Status == RoomStatus.Empty)   // kontrollera om rummet är ledigt
                {
                    room_i.Status = RoomStatus.Occupied;    // byter rummets status
                    room_i.GuestName = guestname;     // gästens namn
                    FileData.SaveRooms(_rooms);       // spara ändring
                    Console.WriteLine();
                    Console.WriteLine("Bokad.");
                    Console.WriteLine();
                    return true;
                }
                else
                {
                    Console.WriteLine("Rummet är inte ledigt. ==> *" + room_i.Status + "*");
                    return false;
                }
            }
            i = i + 1;
            
        }
        Console.WriteLine("hittade inte rum " + RoomNumber + ".");
        return false;
    }



}