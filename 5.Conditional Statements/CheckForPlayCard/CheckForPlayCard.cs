using System;
class CheckForPlayCard
{
    static void Main()
    {
        Console.WriteLine("Въведете символ или число: ");
        string input = Console.ReadLine();

        switch (input)
        {
            case "2": Console.WriteLine("Отговорът е: да,има такава карта"); break;
            case "3": Console.WriteLine("Отговорът е: да,има такава карта"); break;
            case "4": Console.WriteLine("Отговорът е: да,има такава карта"); break;
            case "5": Console.WriteLine("Отговорът е: да,има такава карта"); break;
            case "6": Console.WriteLine("Отговорът е: да,има такава карта"); break;
            case "7": Console.WriteLine("Отговорът е: да,има такава карта"); break;
            case "8": Console.WriteLine("Отговорът е: да,има такава карта"); break;
            case "9": Console.WriteLine("Отговорът е: да,има такава карта"); break;
            case "10": Console.WriteLine("Отговорът е: да,има такава карта"); break;
            case "A": Console.WriteLine("Отговорът е: да,има такава карта"); break;
            case "J": Console.WriteLine("Отговорът е: да,има такава карта"); break;
            case "Q": Console.WriteLine("Отговорът е: да,има такава карта"); break;
            case "K": Console.WriteLine("Отговорът е: да,има такава карта"); break;
            default: Console.WriteLine("Отговорът е: не,няма такава карта"); break;
        }
    }
}
