using System;
class Calculate_NKNK
{
    static void Main()
    {
        Console.Write("Въведете цяло положително число 1<K<100 за K = ");
        int K = int.Parse(Console.ReadLine());
        Console.Write("Въведете цяло положително число K<N<100 , N = ");
        int N = int.Parse(Console.ReadLine());
        int sumK = 1;
        int sumN = 1;
        for (int i = 1; i <= N; i++)
        {
            sumN *= i;
        }
        for (int i = 1; i <= K; i++)
        {
            sumK *= i;
        }
        for (int i = 1; i <= (N - K); i++)
        {
             (N - K) *= i;
        }

    }
}
