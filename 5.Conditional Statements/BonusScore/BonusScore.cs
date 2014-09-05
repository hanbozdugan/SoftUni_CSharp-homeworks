using System;
class BonusScore
{
    static void Main()
    {
        Console.WriteLine("Въведете число: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Въведете второ число: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Сборът на числата е: {0}", a + b);
        if (a + b == 1 || a + b == 2 || a + b == 3)
        {
            Console.WriteLine("Към резултатът ще се прибави бонус 10,с което резултатът става: {0}", a + b + 10);
        }
        else if (a + b== 4 || a+b == 5 || a+b == 6)
        {
            Console.WriteLine("Към сборът ще се прибави бонус 100,с което резултатът ще стане: {0}",a+b+100);
        }
        else if (a + b == 7 || a + b == 8 || a + b == 9)
        {
            Console.WriteLine("Към сборът ще се прибави бонус 1000,с което резултатът ще стане: {0}", a + b + 1000);
        }
        else
        {
            Console.WriteLine("Невалиден разултат");
        }
    }
}
