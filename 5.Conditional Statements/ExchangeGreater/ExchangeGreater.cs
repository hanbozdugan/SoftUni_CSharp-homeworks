using System;
class ExchangeGreater
{
    static void Main()
    {
        Console.WriteLine("Въведете число: ");
        decimal a = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Въведете второ число: ");
        decimal b = decimal.Parse(Console.ReadLine());
        if (a > b)
        {
            Console.Write("{0} {1}  ",b,a);
        }
        else
        {
            Console.Write("{0} {1}  ",a,b);
        }
    }
}
