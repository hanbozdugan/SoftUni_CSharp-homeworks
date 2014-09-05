using System;
class ExchangeVariableValues
{
    static void Main()
    {
        int a, b;
        a=5;
        b=10;
        a=a+b;
        b=a-b;
        a=a-b;
        Console.WriteLine("Оригинални променливи:\na = 5\nb = 10\n\nНови променливи:\na = {0}\nb = {1}", a, b);
       
    }
}
