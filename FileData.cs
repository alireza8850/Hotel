namespace App;

public static class FileData
{
    private const string RoomsFile = "Rooms.txt";                            //värden ska sparas i Rooms.txt
    private const char Seperate = ',';
    public static List<Room> AllRooms()                 //ladda alla rum
    {
        List<Room> rooms = new List<Room>();                //skapa en tom lista för rum


        if (!File.Exists(RoomsFile))                    //kolla om filen inte finns, skapa 10 rum och spara dem till fil
        {
            int a = 0;
            while (a < 10)
            {
                int RoomNumber = 1 + a;
                rooms.Add(new Room(RoomNumber, RoomStatus.Empty, ""));
                a = a + 1;
            }
            SaveRooms(rooms);
            return rooms;
        }
        // Bara en notering för mig själv
        // vi behöver läsa alla rader, dela upp, konvertera till rätt typer, bygga room objekt och lägga i listan
        // (göra om texten i Rooms.txt till riktig room objekt i minnet)

        string[] lines = File.ReadAllLines(RoomsFile);
        if (lines.Length == 0)
                {
                    int a = 0;
                    while (a < 10)
                    {
                        int RoomNumber = 1 + a;
                        rooms.Add(new Room(RoomNumber, RoomStatus.Empty, ""));
                        a = a + 1;

                    }
                    SaveRooms(rooms);
                    return rooms;
                }




        int i = 0;
        while (i < lines.Length)
        {
            string line = lines[i];
            if (!string.IsNullOrWhiteSpace(line))
            {
                string[] p = line.Split(Seperate);


                int number;     // kom_ihåg_note: number deklareras här innan nästa raden

                bool Ok = int.TryParse(p[0], out number); // note: här tryparse försöker göra om string till int

                RoomStatus status;
                bool OkStatus = Enum.TryParse(p[1], out status);


                string guest = p[2];  // gästens namn kan vara tom för att rummet kan vara ledig eller otillgänligt

                if (Ok && OkStatus)
                {
                    rooms.Add(new Room(number, status, guest));
                }
            }
            i = i + 1;

        }
        return rooms;
    }


    // notering: vi behöver spara ändringar till fil tex bokningar, utchekningar och status
    public static void SaveRooms(List<Room> rooms)
    {
        List<string> lines = new List<string>();
        int i = 0;
        while (i < rooms.Count)
        {
            Room room_i = rooms[i];
            string guest;
            if (string.IsNullOrWhiteSpace(room_i.GuestName))
            {
                guest = "";
            }
            else
            {
                guest = room_i.GuestName;
            }
            string line = room_i.Number + Seperate.ToString() + room_i.Status + Seperate.ToString() + guest;
            lines.Add(line);
            i = i + 1;

        }
        File.WriteAllLines(RoomsFile, lines.ToArray());
    }

}