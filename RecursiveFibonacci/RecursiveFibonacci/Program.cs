using System;

namespace RecursiveFibonacci
{
    class Program
    {
        public static long[] memo;
        public static long counter;

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            memo = new long[n + 1];
            counter = 0;

            Console.WriteLine(Fibbonacci(n));
        }

        static long Fibbonacci(int n)
        {
            if (memo[n] != 0)
            {
                return memo[n];
            }

            counter++;

            if (n == 0)
                return 0;
            if (n == 1 || n == 2)
                return 1;

            memo[n] = Fibbonacci(n - 1) + Fibbonacci(n - 2);
            return memo[n];
        }
    }
}