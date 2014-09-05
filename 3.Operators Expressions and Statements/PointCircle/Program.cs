using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Въведете Х координата на точката:");
        decimal pointX = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Въведете Y координата на точката");
        decimal pointY = decimal.Parse(Console.ReadLine());
        byte radius = 2;
        bool isInCircle = pointX * pointX + pointY * pointY <= radius * radius;
        Console.WriteLine("Точката в кръга ли е?\n{0}", isInCircle);
    }
}
