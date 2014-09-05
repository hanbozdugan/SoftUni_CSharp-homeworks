using System;
class MultiplicationSign
{
    static void Main()
    {
        Console.WriteLine("Въведете число: ");
        decimal a = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Въведете второ число: ");
        decimal b = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Въведете трето число: ");
        decimal c = decimal.Parse(Console.ReadLine());
        if (a * b * c < 0)
        {
            Console.WriteLine("Произведението на трите числа е с знак:  -");
        }
        else if (a * b * c > 0)
        {
            Console.WriteLine("Произведението на трите числа е с знак: +");
        }
        else
        {
            Console.WriteLine("Произведението на трите числа е: 0");
        }
    }
}
