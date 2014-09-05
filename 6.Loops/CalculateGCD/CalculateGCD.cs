using System;
class CalculateGCD
{
    static void Main()
    {
        Console.Write("Въведете число a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Въведете второ число b = ");
        int b = int.Parse(Console.ReadLine());
        int remain = a % b;
        while (remain != 0)
        {
            a = b;
            b = remain;
            remain = a % b;
        }
        Console.WriteLine(b);
    }
}