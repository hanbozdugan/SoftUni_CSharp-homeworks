using System;
class CalculateXN
{
    static void Main()
    {
        Console.Write("Моля , въведете цяло положително число за n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Въведете цяло число за x = ");
        int x = int.Parse(Console.ReadLine());

        double factN = 1;
        double multiX = 1;
        double result = 1;

        for (int i = 1; i <= n; i++)
        {
            factN *= i;
            multiX *= x;
            result += factN / multiX;
        }

        Console.WriteLine("Сумата на последователноста на тези числа N и X е = {0:F5}", result);
        }
    }

