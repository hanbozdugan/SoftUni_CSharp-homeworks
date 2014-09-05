using System;
class TheBiggest3Numbers
{
    static void Main()
    {
        Console.WriteLine("Въведете число: ");
        decimal a = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Въведете второ число: ");
        decimal b = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Въведете трето число: ");
        decimal c = decimal.Parse(Console.ReadLine());
        if (a >= b && a >= c)
        {
            Console.WriteLine("От трите числа най-голямо е: {0}", a);
        }
        else if (b >= a && b >= c)
        {
            Console.WriteLine("От трите числа най-голямо е: {0}", b);
        }
        else
        {
            Console.WriteLine("От трите числа най-голямо е {0}", c);
        }
    }
}
