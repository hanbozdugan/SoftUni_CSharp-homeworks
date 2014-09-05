using System;
class BitwiseExtractBit3
{
    static void Main()
    {
        Console.WriteLine("Въведете число:");
        uint a = uint.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(a, 2).PadLeft(16, '0'));
        uint moveNumber = a >> 3;
        uint bit = moveNumber & 1;
        Console.WriteLine("Стойността на bit #3 е:");
        Console.WriteLine(Convert.ToString(bit, 2));
    }
}
