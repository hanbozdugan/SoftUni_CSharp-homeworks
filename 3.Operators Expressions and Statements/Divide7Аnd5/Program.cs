using System;
class Divide7And5
{
    static void Main()
    {
        Console.WriteLine("Въведете число,което ще се провери дали ще се дели на 5 или 7 без остатък:");
        int number = int.Parse(Console.ReadLine());
        if ((number % 5 == 0) && (number % 7 == 0))
        Console.WriteLine("Числото може да бъде разделено на 5 и 7 без остатък!");
        else
        Console.WriteLine("Числото не може да бъде разделено на 5 и 7 без остатък!");
    }
}
