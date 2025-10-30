namespace App;

public static class Login
{
    private const string UserFile = "UserInlog.txt";

    public static bool TryLogin (string username, string password)
    {
        string[] Lines = File.ReadAllLines(UserFile);
        int i = 0;
        while (i < Lines.Length)   // loop för att kolla alla rader
        {
            string Line = Lines[i];       //rad i
            string[] p = Line.Split(',');    //dela på ,

            string u = p[0];
            string pass = p[1];

            if (u == username && pass == password)
            {
                return true;
            }

            i = i + 1;
        }
        return false;
    }
}