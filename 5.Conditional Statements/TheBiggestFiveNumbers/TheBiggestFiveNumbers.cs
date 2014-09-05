using System;
class TheBiggestFiveNumbers
{
    static void Main()
    {
        Console.WriteLine("Въведете число: ");
        decimal a = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Въведете второ число: ");
        decimal b = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Въведете трето число: ");
        decimal c = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Въведете четвърто число: ");
        decimal d = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Въведете пето число: ");
        decimal e = decimal.Parse(Console.ReadLine());
        if (a >= b && a >= c && a >= d && a >= e)
        {
            Console.WriteLine("Най-голямото от петте числа е: {0}", a);
        }
        else if (b >= a && b >= c && b >= d && b >= e)
        {
            Console.WriteLine("Най-голямото от петте числа е: {0}", b);
        }
        else if (c >= a && c >= b && c >= d && c >= e)
        {
            Console.WriteLine("Най-голямото от петте числа е: {0}", c);
        }
        else if (d >= a && d >= b && d >= c && d >= e)
        {
            Console.WriteLine("Най-голямото от петте числа е: {0}", d);
        }
        else
        {
            Console.WriteLine("Най-голямото от петте числа е: {0}", e);
        }
    }
}
