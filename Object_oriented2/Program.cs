using System;

namespace Object_oriented2
{
    // 은닉성

    class Knight
    {
        // 접근 한정자
        // public protected private
        //private int hp;

        protected int hp; // 외부에서는 사용안되지만 자식class에서는 사용 가능.
        // int hp; 아무것도 없으면 private로 동작함.
    }

    class SuperKnight : Knight
    {
        void Test()
        {
            hp = 10; //가능
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight();
            
        }
    }
}
