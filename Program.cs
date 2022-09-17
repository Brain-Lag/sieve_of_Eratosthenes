using System;
using System.Diagnostics;
using System.Threading;

Stopwatch stopwatch = new();
while (true)
{
    Console.WriteLine("Введите число");
    int N = int.Parse(Console.ReadLine());

    stopwatch.Start();

    bool[] A = new bool[N];

    double sqrt = Math.Sqrt(N) + 1;

    for (int i = 2; i < sqrt; i++)
    {
        if (!A[i])
        {
            for (int j = i * i; j < N; j += i)
            {
                A[j] = true;
            }
        }
    }
    Console.WriteLine();

    for (int i = 2; i < N; i++)
    {
        if (!A[i])
        {
            Console.Write("{0} ", i);
        }
    }
    stopwatch.Stop();
    Console.WriteLine($"--------Прошло милисекунд: {stopwatch.ElapsedMilliseconds}");
    Console.WriteLine();
}