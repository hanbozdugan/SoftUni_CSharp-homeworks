using System;
class NumbersNotDivisible3And7
{
    static void Main()
    {
        Console.WriteLine("Въведете целочислено положително число: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Числата,които не се делят на 3 и на 7 са:");
        for (int i=1;i<=n;i++)
        {
            if ((i % 7 == 0) || (i % 3 == 0))
            {
                continue;
            }
            Console.Write(" {0} ",i);
        }
    }
}