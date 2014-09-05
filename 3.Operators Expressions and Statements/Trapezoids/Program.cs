using System;
class Trapezoids
{
    static void Main()
    {
        Console.Title ="Лице на трапец";
        Console.WriteLine("Въведи страна а:");
        decimal a = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Въведи страна b:");
        decimal b = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Въведи височина h:");
        decimal h = decimal.Parse(Console.ReadLine());
        decimal S= ((a + b) / 2) * h;
        Console.WriteLine("Лицето на трапеца е: " + S);
    }
}
