using System;
class Program
{
    static void Main()
    {
        bool isFemale;
        Console.WriteLine("Please your gender:");
        string enterGender = Console.ReadLine();
        if (enterGender == "female")
        isFemale = true;
        else
        isFemale = false;
        Console.WriteLine(new string('-', 40));
        Console.WriteLine("Are you female? -> {0}.", isFemale);
    }
}
