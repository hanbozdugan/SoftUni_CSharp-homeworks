﻿using System;
using System.Collections.Generic;

class ZeroSubset
{

    static void Main()
    {
        Console.WriteLine("Въведете 5 целочислени числа,като между тях се остави интервал:");
        const int LEN = 5;
        string pattern;
        int[] a = new int[LEN];

        string[] values = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < LEN; i++)
        {
            a[i] = int.Parse(values[i]);
        }

        int zerosCount = 0, currentSum;
        List<int> numbers;
        for (int i = 1, m = (int)Math.Pow(2, LEN); i < m; i++)
        {
            pattern = Convert.ToString(i, 2).PadLeft(LEN, '0');
            currentSum = 0;
            numbers = new List<int>();
            for (int j = 0; j < LEN; j++)
            {
                if (pattern[j] == '1')
                {
                    currentSum += a[j];
                    numbers.Add(a[j]);
                }
            }
            if (currentSum == 0)
            {
                zerosCount++;
                if (numbers.Count > 1)
                {
                    for (int j = 0; j < numbers.Count - 1; j++)
                    {
                        Console.Write("{0} + ", numbers[j]);
                    }
                    Console.WriteLine("{0} = 0", numbers[numbers.Count - 1]);
                }
                else
                {
                    Console.WriteLine("{0} = 0", numbers[0]);
                }
            }
        }
        if (zerosCount > 0)
        {
            Console.WriteLine("Общо: {0} подмножество(а), чиято сума е равна на 0", zerosCount);
        }
        else
        {
            Console.WriteLine("Няма цифри,чийто сбор е равен на 0");
        }
    }
}

