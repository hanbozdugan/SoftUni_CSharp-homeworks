using System;
class CheckBitGivenPosition
{
    static void Main()
    {
        Console.WriteLine("Въведете число:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Въведете позиция p:");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(a, 2).PadLeft(16, '0'));
        int moveNumber = a >> p;
        bool isBitValue1 = (moveNumber & 1) == 1;

        Console.WriteLine("Дали битът на позиция р имат стойност 1?");
        Console.WriteLine(isBitValue1);
    }
}
