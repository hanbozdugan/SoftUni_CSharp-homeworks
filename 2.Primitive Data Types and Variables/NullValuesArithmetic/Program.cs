﻿using System;
class NullValuesArithmetic
{
    static void Main()
    {
        int? number1 = null;
        double? number2 = null;
        number1 = number1 + 100;
        number2 = number2 + 100.5;
        Console.WriteLine("{0};{1}", number1.GetValueOrDefault(), number2.GetValueOrDefault());
     }
}
