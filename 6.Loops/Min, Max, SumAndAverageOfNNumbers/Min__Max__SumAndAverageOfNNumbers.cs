﻿using System;
class Min__Max__SumAndAverageOfNNumbers
{
    static void Main()
    {
        Console.Write("Въведете броя на цифрите: ");
        int length = int.Parse(Console.ReadLine());

        int min = int.MaxValue;
        int max = int.MinValue;
        double sum = 0;
        double avg = 0;

        for (int i = 0; i < length; i++)
        {
            int number = int.Parse(Console.ReadLine());
            min = Math.Min(min, number);
            max = Math.Max(max, number);
            sum += number;
            avg = sum / length;
        }
        Console.WriteLine("Min = " + min);
        Console.WriteLine("Max = " + max);
        Console.WriteLine("Сумата на всички числа е:  " + sum);
        Console.WriteLine("Средна стойност на всички числа е:  {0:F2}", avg);
    }
}
