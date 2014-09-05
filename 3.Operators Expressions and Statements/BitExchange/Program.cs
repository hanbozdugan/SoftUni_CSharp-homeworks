using System;
class BitExchange
{
    static void Main()
    {
        Console.WriteLine("Въведете число:");
        uint number=uint.Parse(Console.ReadLine());
        Console.WriteLine("Двоично представяне на числото:");
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        for (int i = 3; i < 6; i++)
        if ((number >> i & 1U) != (number >> (i + 21) & 1U))
            if ((number >> i & 1U) == 1)
            {
                number = ~(1U << i) & number;
                number = (1U << (i + 21)) | number;
            }
            else
            {
                number = (1U << i) | number;
                number = ~(1U << (i + 21)) & number;
            }
        Console.WriteLine("След смяната резултатът е: ");
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        
    }
}
