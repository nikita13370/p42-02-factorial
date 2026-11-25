using System;

class Program
{
    // Верните n! = 1 * 2 * ... * n (0! = 1)
    static long Factorial(int n)
    {
        // TODO: напишите решение здесь
    long result = 1;

for (int i = 1; i <= n; i++)
{
    result *= i;
}

return result;
    }

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Check(5, 120);
        Check(4, 24);
        Check(0, 1);
        Check(1, 1);
        Check(10, 3628800);
        Check(15, 1307674368000);
    }

    static void Check(int n, long expected)
    {
        long result = Factorial(n);
        string status = result == expected ? "OK" : "ОШИБКА";
        Console.WriteLine($"n = {n}: получено {result}, ожидалось {expected} - {status}");
    }
}
