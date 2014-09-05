using System;
class NumbersFrom1ToN
{
    static void Main()
    {
        Console.WriteLine("Въведете целочислено положително число: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Всички целочислени числа до числото {0} са:",n);
        for (int i = 1; i <= n; i++)
        {
           Console.Write(" {0} ",i);
        }
    }
}
