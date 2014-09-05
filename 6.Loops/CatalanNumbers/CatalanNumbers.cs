using System;
using System.Numerics;
class CatalanNumbers
{
    static void Main()
    {
        Console.Write("Въведете число (1 < N < 100) N = ");
        int N = int.Parse(Console.ReadLine());
        if (1 < N && N < 100)
        {
            BigInteger fact2N = 1;
            BigInteger factN1 = 1;
            BigInteger factN = 1;
            BigInteger result = 0;
            for (int i = 1; i <= (2 * N); i++)
            {
                fact2N *= i;
            }
            for (int j = 1; j <= (N + 1); j++)
            {
                factN1 *= j;
            }
            for (int k = 1; k <= N; k++)
            {
                factN *= k;
            }
            result = fact2N / (factN1 * factN);
            Console.WriteLine("Каталонското число изчислено по формулата (2N)!/((N+1)!*N!) е: " + result);
        }
        else
        {
            Console.WriteLine("Невалидно число!");
        }
    }
}
