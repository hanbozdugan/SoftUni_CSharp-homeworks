using System;
class PrimeNumberCheck
{
    static void Main()
    {
        string number = null;
        Console.Write("Въведи число: ");
        number = Console.ReadLine();
        int intNumber = int.Parse(number);
        double squareNumber = Math.Sqrt(intNumber);
        bool flag = true;
        for (int i = 2; i <= squareNumber; i++)
            if (intNumber % i == 0)
            {
                flag = false;
                break;
            }
        Console.WriteLine("Това число просто ли е? {0}", flag);
    }
}
