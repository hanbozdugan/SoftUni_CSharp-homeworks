using System;
class DigitWord
{
    static void Main()
    {
        string inputValue = Console.ReadLine();
        double digit;
        bool parseSuccess = double.TryParse(inputValue, out digit);
        switch (inputValue)
        {
            case "0": Console.WriteLine("Нула"); break;
            case "1": Console.WriteLine("Едно"); break;
            case "2": Console.WriteLine("Две"); break;
            case "3": Console.WriteLine("Три"); break;
            case "4": Console.WriteLine("Четири"); break;
            case "5": Console.WriteLine("Пет"); break;
            case "6": Console.WriteLine("Шест"); break;
            case "7": Console.WriteLine("Седем"); break;
            case "8": Console.WriteLine("Осем"); break;
            case "9": Console.WriteLine("Девет"); break;
            default: if ((digit < 0) || (digit > 9))
                {
                    Console.WriteLine("Това е символ или не е едноцифрено число!!!");
                }
                break;
        }
    
    }
}   