using System;
class FourDigitNumber
{
    static void Main()
    {
        Console.WriteLine("Моля въведете четирицифрено число:");
        int number = int.Parse(Console.ReadLine());
        int A = number / 1000;
        int B = (number / 100) % 10;
        int C = (number / 10) % 10;
        int D = number % 10;
        int sum = A + B + C + D;
        Console.WriteLine("Сумата от цифрите на числото е: " + sum);
        Console.WriteLine("Числото в обратен ред е: {0} {1} {2} {3}",D,C,B,A);
        Console.WriteLine("Последна цифра на първи ред: {0} {1} {2} {3}",D,A,B,C);
        Console.WriteLine("Размененa втората и третата цифра на числото: {0} {1} {2} {3}",A,C,B,D);
    }
}
