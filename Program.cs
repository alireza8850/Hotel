using App;



Console.WriteLine("5 star Hotel");
Console.WriteLine("Ange ditt användarnamn: ");
string? username = Console.ReadLine();
Console.WriteLine("Ange ditt lösenord: ");
string? password = Console.ReadLine();



bool running = true;

while (running)
{
    // Man ska kunna dessa: Se lista av upptagna rum och lediga rum, boka in, checka ut, markera otillgänligt
    Console.WriteLine("*****Meny*****");
    Console.WriteLine("____________________");
    Console.WriteLine();
    Console.WriteLine("1. Upptagna rum.");
    Console.WriteLine("2. Lediga rum.");
    Console.WriteLine("3. Boka in en gäst.");
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

            break;
        
    }
    
}