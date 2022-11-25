using System;

namespace Delegate
{
    class Program
    {

        delegate int OnClicked();
        delegate int OnClicked2(int x);
        // delegate -> 형식은 형식인데, 함수 자체를 인자로 넘겨주는 형식
        // return은 int 입력 : void
        // Onclicked가 delegate형식의 이름.

        static void ButtonPressed(OnClicked clickedFunction)
        {
            clickedFunction();
        }

        // [ 10 20 40 30 50 ]

        static int TestDelegate()
        {
            Console.WriteLine("Hello Delegate");
            return (0);
        }

        static int TestDelegate2()
        {
            Console.WriteLine("Hello Delegate2");
            return (0);
        }

        static int TestDelegate3(int x)
        {
            Console.WriteLine(x);
            return (0);
        }

        static void Main(string[] args)
        {
            OnClicked clicked = new OnClicked(TestDelegate);
            clicked += TestDelegate2;

            OnClicked2 clicked2 = new OnClicked2(TestDelegate3);

            ButtonPressed(clicked);
            clicked2(10);
        }
    }
}