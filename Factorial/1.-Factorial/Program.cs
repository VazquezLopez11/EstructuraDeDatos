using System;
class Program
{
    static long Factorial(int n)
    {
        if (n == 0) return 1;

        return n * Factorial(n - 1);
    }
    static void Main()
    {
        Console.WriteLine("ingrse un numero:");
        int n = int.Parse(Console.ReadLine());

        if (n < 0 || n > 20)
        {
            Console.WriteLine("ingresa un numero entre 0 y 20");
            return;
        }

        Console.WriteLine("Factorial:" + Factorial(n));
    }
}


