using System;

namespace code_flow_control
{
    class Program
    {
        /* Method Function Procedure(함수) */
        // class 안에 있어야함.
        static void HelloWorld()
        {
            Console.WriteLine("Hello World");
        }

        // 덧셈 함수
        static int Add(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            //int choice = 0; // 0:가위 1:바위 2:보 3:치트키

            //switch (choice)
            //{
            //    case 0:
            //        Console.WriteLine("가위입니다.");
            //        break;
            //    case 1:
            //        Console.WriteLine("바위입니다.");
            //        break;
            //    case 2:
            //        Console.WriteLine("보입니다.");
            //        break;
            //    case 3:
            //        Console.WriteLine("치트키입니다.");
            //        break;
            //    default:
            //        Console.WriteLine("다 실패했습니다.");
            //        break;
            //}
            ////if (choice == 0)
            ////    Console.WriteLine("가위입니다.");
            ////else if (choice == 1)
            ////    Console.WriteLine("바위입니다.");
            ////else if (choice == 2)
            ////    Console.WriteLine("보입니다.");
            ////else
            ////    Console.WriteLine("치트키입니다.");

            //// 삼항연산자

            //int number = 25;

            //bool isPair = ((number % 2) == 0 ? true : false);

            //if ((number % 2) == 0)
            //    isPair = true;
            //else
            //    isPair = false;


            /* while 반복문 */

            //int count = 5;

            //while (count > 0)
            //{
            //    Console.WriteLine("Hello World");
            //    count--;
            //}

            //string answer;

            //do // 한번은 무조건 들어옴.
            //{
            //    Console.WriteLine("강사님은 잘생기셨나요? (y/n) : ");
            //    answer = Console.ReadLine();
            //} while (answer != "y");

            //Console.WriteLine("정답입니다.");

            /* for 반복문 */

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Hello World");
            //}

            /* break, continue */

            //int num = 97; // 1, 97로만 나뉘는 숫자

            //bool isPrime = true;

            //for (int i = 2; i < num; i++)
            //{
            //    if ((num % i) == 0)
            //    {
            //        isPrime = false;
            //        break;
            //    }
            //}

            //if (isPrime)
            //    Console.WriteLine("소수입니다!");
            //else
            //    Console.WriteLine("소수가 아닙니다!");

            //for (int i = 1; i <= 100; i++)
            //{
            //    if ((i % 3) != 0)
            //        continue;

            //    Console.WriteLine($"3으로 나뉘는 숫자 발견 : {i}");
            //}

            //Program.HelloWorld();

            //int result = Program.Add(4, 5);

            //Console.WriteLine(result);

        }// main
    }
}