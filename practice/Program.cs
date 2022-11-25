using System;

namespace practice
{
    class Program
    {
        static int Factorial(int n)
        {
            //int ret;

            //ret = 1;
            //while (n > 0)
            //{
            //    ret *= n;
            //    n--;
            //}
            //return (ret);
            if (n <= 1)
                return 1;
            return (n * Factorial(n - 1));
        }

        static void Main(string[] args)
        {
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            int ret = Factorial(5);
            Console.WriteLine(ret);
        }
    }
}