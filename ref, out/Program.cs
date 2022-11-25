using System;

namespace ref_out
{
    class Program
    {
        //static void Swap(ref int a, ref int b)
        //{
        //    int temp;

        //    temp = a;
        //    a = b;
        //    b = temp;
        //}
        //static void AddOne(ref int number)
        //{
        //    number = number + 1;
        //}

        //static int AddOne2(int number)
        //{
        //    return number + 1;
        //}

        static void Divide(int a, int b, out int result1, out int result2)
        {
            result1 = a / b;
            result2 = a % b;
        }

        static void Main(string[] args)
        {
            //int num1 = 1;
            //int num2 = 2;
            //Program.Swap(ref num1, ref num2);
            //Console.WriteLine(num1);
            //Console.WriteLine(num2);
            int num1 = 10;
            int num2 = 3;

            int result1;
            int result2;
            Divide(num1, num2, out result1, out result2);

            Console.WriteLine(result1);
            Console.WriteLine(result2);
        }
    }
}