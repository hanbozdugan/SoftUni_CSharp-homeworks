using System;
class ExtractBitFroмInteger
{
    static void Main()
    {
        Console.WriteLine("Въведете число:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Въведете позиция p:");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(a, 2).PadLeft(16,'0'));
        int moveNumber=a>>p;
        int bit=moveNumber&1;
        Console.WriteLine("Стойността на bit# e:");
        Console.WriteLine(Convert.ToString(bit, 2));
    }
}