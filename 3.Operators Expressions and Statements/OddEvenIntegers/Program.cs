using System;
class OddEvenIntegers
{
    static void Main()
    {
        Console.WriteLine("Моля, въведете число, за да се види дали е четно или нечетно.");
        int number = int.Parse(Console.ReadLine());
        if (number % 2 == 0)
        Console.WriteLine("Числото е четно");
        else
        Console.WriteLine("Числото е нечетно");
    }
}
