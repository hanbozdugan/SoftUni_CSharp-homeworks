using System;
class ThirdDigit7
{
    static void Main()
    {
        Console.Write("Моля,въведете число: ");
        int number = int.Parse(Console.ReadLine());
        int thirdDigit = (number / 100) % 10; 
        if (thirdDigit == 7)
        Console.WriteLine("Третата цифра от числото е седем!");
        else
        Console.WriteLine("Третата цифра от числото не е седем!");
    }
}
