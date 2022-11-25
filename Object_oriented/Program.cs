using System;

namespace Object_oriented
{
    // 객체(OOP Object Oriented Programming)

    // OOP(은닉성/상속성/다형성)

    class Player // 부모 class 혹은 기반 class
    {
        // 필드
        static public int counter = 1;// 오로지 1개만 존재. 모든 Knight가 공유하는 필드.

        public int id;
        public int hp;
        public int attack;// public없으면 class내부에서만 사용.

        public Player()
        {
            Console.WriteLine("Player 생성자 호출!");
        }

        public Player(int hp)
        {
            this.hp = hp;
            Console.WriteLine("Player hp 생성자 호출!");
        }

        public void Move()
        {
            Console.WriteLine("Knight Move");
        }

        public void Attack()
        {
            Console.WriteLine("Knight Attack");
        }

    }

    class Mage : Player
    {

    }

    class Archer : Player
    {

    }

    class Knight : Player // 자식 class 혹은 파생 클래스
    {
        //int c;

        //public Knight() : base(100)
        //{
        //    this.c = 10;
        //    base.hp = 100;
        //    Console.WriteLine("Knight 생성자 호출!");
        //}

        //static public void Test() //static 함수내에서는 this를 통해 필드 접근 x
        //{
        //    counter++; // static 변수만 접근이 가능하다.
        //}

        //static public Knight CreateKnight()
        //{
        //    Knight knight = new Knight();
        //    knight.hp = 100;
        //    knight.attack = 10;
        //    return (knight);
        //}

        //public Knight(int hp) : this()// 이곳에 빈 생성자를 호출해달라.
        //{
        //    this.hp = hp;
        //    Console.WriteLine("int 생성자 호출!");
        //}

        //public Knight Clone()
        //{
        //    Knight knight = new Knight();
        //    knight.hp = hp;
        //    knight.attack = attack;
        //    return (knight);
        //}

        //public void Move()
        //{
        //    Console.WriteLine("Knight Move");
        //}

        //public void Attack()
        //{
        //    Console.WriteLine("Knight Attack");
        //}
    }

    class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight();//반드시 생성을 실제로 해줘야함.
            knight.Move();
        }
    }
}