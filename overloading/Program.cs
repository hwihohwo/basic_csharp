using System;

namespace overloading
{
    class Program
    {
        // 함수 이름의 재사용
        static int Add(int a, int b)
        {
            Console.WriteLine("Add int 호출");
            return (a + b);
        }

        static float Add(float a, float b) 
        {
            Console.WriteLine("Add float 호출");
            return (a + b);
        }

        static int Add(int a, int b, int c = 0, float d = 1.0f, double e = 3.0) // 선택적 매개변수 호출 c에 아무 인자도 안넘겨주면 0으로 사용.
        {
            Console.WriteLine("Add int 3개 호출");
            return a + b + c;
        }
        // 재사용시 parameter가 동일하면 안됨. parameter순서는 무관.
        static void Main(string[] args)
        {
            int ret = Program.Add(2, 3, 4);
            float ret2 = Program.Add(2.0f, 3.0f);
            int ret3 = Program.Add(2, 3, e:4.0);//원하는 인자만 지정해서 넣어줄 수 있음.(c#에서만 가능).
            //Console.WriteLine(ret);
        }
    }
}