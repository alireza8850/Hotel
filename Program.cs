using App;
bool running = true;

    Console.Clear();
    Console.WriteLine("5 star Hotel");
    Console.WriteLine();
    Console.WriteLine("Ange ditt användarnamn: ");
    string? Username = Console.ReadLine();
    Console.Clear();
    Console.WriteLine("Ange ditt lösenord: ");
    string? Password = Console.ReadLine();
    Console.Clear();

    bool ok = Login.TryLogin(Username, Password);
    if (!ok)
    {
        Console.WriteLine("Fel inloggning. Försök igen.");
        return;

    }

    List<Room> rooms = FileData.AllRooms();
Reception Hotel = new Reception(rooms);
    
while (running)
{
    Console.Clear();
    // Man ska kunna dessa: Se lista av upptagna rum och lediga rum, boka in, checka ut, markera otillgänligt
    Console.WriteLine("*****Meny*****");
    Console.WriteLine("____________________");
    Console.WriteLine();
    Console.WriteLine("1. Upptagna rum.");                  //Klar
    Console.WriteLine("2. Lediga rum.");                    //Klar
    Console.WriteLine("3. Boka in en gäst.");               //Klar
    Console.WriteLine("4. Checka ut gäst.");
    Console.WriteLine("5.Markera rum som temporärt otillgänligt.");
    Console.WriteLine("0. Avsluta");
    Console.WriteLine("_____________________");
    Console.WriteLine();
    Console.WriteLine("Val: ");
    string? input = Console.ReadLine();
    switch (input)
    {
        case "1":

            Hotel.ShowOccupiedRooms();

            break;

        case "2":
            Hotel.Available();
            break;

        case "3":
            Console.WriteLine("Rum nummer: ");
            string input2 = Console.ReadLine();
            int RoomNumber;
            if (!int.TryParse(input2, out RoomNumber))    //använder tryparse metoden för att försöka omvandla inputen till int
            {
                Console.WriteLine("Ogiltigt nummer.");  // om omvandligen misslycaks skriv detta
            }
            else
            {
                Console.WriteLine("Gästens namn: ");
                string Name = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(Name))       
                {
                    Console.WriteLine("Ogiltigt namn.");     // om den är tom eller white space skriv detta

                }
                else                                    
                {
                    Hotel.BookIn(RoomNumber, Name);
                    Console.WriteLine("Trycket Enter för att fortsätta.");
                    Console.ReadLine();
                }

            }
            break;

        case "0":
                    running = false;
                    Console.Clear();
                    Console.WriteLine(":)");

                    break;

                }
    
}