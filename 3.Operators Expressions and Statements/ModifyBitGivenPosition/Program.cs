using System;
class ModifyBitGivenPosition
{
    static void Main()
    {
        Console.WriteLine("Въведете число:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Въведете позиция p:");
        int p= int.Parse(Console.ReadLine());
        Console.WriteLine("Въведете стойност 0 или 1 за бита за индекс p:");
        int bitValue = int.Parse(Console.ReadLine());
        Console.WriteLine("Двоично представяне на числото:");
        Console.WriteLine(Convert.ToString(a, 2).PadLeft(16, '0'));
        int mask = bitValue << p;
        int result = a | mask;
        if (bitValue == 0)
        mask = ~(1 << p);
        result = a & mask;
        Console.WriteLine("Двоичен резултат:");
        Console.WriteLine(Convert.ToString(result, 2).PadLeft(16, '0'));
        Console.WriteLine("Десетичен резултат:");
        Console.WriteLine(result);
    }
}
