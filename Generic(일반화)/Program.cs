using System;
using System.Collections.Generic;

namespace Generic
{
    class Program
    {
        class MyList<T> where T : new()//어떤 type이 들어와도 작동한다. T에 대한 조건을 걸어줄 수 있음.
        {
            T[] arr = new T[10];

            public T GetItem(int i)
            {
                return (arr[i]);
            }
        }

        class Monster
        {

        }

        static void Test<T>(T input)
        {

        }

        static void Main(string[] args)
        {
            //var obj3 = 3;
            //var obj4 = "hello world";
            //// var는 컴파일러가 타입을 알아서 배정함.
            //object obj = 3;
            //object obj2 = "hello world";
            ////object는 자체 타입이 object.
            ////class상속을 통해 가능한것. object가 다른 자료형들의 부모 class
            ////모두 object로 하면 매우 느려짐.

            //int number = 3;

            //int num = (int)obj;
            //string str = (string)obj2;
            MyList<int> myIntlist = new MyList<int>();
            int item = myIntlist.GetItem(0);
            
        }
    }
}