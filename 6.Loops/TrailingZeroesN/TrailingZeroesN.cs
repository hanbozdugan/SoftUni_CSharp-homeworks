using System;
using System.Numerics;
class TrailingZeroesN
{
    static void Main()
    {
        Console.Write("Въведете число n = ");
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        BigInteger factN = 1;
        for (int i = 1; i <= n; i++)
        {
            factN *= i;
        }
        Console.WriteLine("n! = "+factN);
        Console.WriteLine("Завършващите нули на числото n! = " + (n / 5));
     }
}