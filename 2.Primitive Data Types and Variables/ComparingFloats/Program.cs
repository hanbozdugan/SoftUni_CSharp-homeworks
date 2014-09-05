using System;
class ComparingFloat
{
    static void Main()
    {
        bool result = false;
        Console.WriteLine("Напишете първото число:");
        double number1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Напишете второто число:");
        double number2 = double.Parse(Console.ReadLine());
        double deduction = number1 - number2;
        deduction = Math.Abs(deduction);
        Console.WriteLine(deduction);
        if (deduction < 0.000001)
        result = true;
        Console.WriteLine("({0};{1})\u2192{2}", number1, number2, result);
    }
}
