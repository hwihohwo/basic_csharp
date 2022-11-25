using System;

namespace Object_oriented3
{
    // 클래스 형식 변환
    // 다형성
    class Player
    {
        protected int hp;
        protected int attack;

        public virtual void Move()
        {
            Console.WriteLine("Player 이동!");
        }
    }

    class Knight : Player
    {
        public override void Move()
        {
            base.Move();

            Console.WriteLine("Knight 이동!");
        }
    }

    class SuperKnight : Knight
    {
        public override void Move()
        {
            base.Move();
            Console.WriteLine("test");
        }
    }

    class Mage : Player
    {
        public int mp;
        public override void Move()
        {
            Console.WriteLine("Mage 이동!");
        }
    }

    class Program
    {
        static void EnterGame(Player player)
        {
            player.Move();
            //bool isMage = (player is Mage);
            //Mage mage = player as Mage; //as가 조금 더 추천되는 방법(코드가 깔끔)
            //if (mage != null)
            //{
            //    mage.mp = 10;
            //    mage.Move();
            //}
        }

        static void Main(string[] args)
        {
            Knight knight = new Knight();
            Mage mage = new Mage();
            SuperKnight superknight = new SuperKnight();

            //knight.Move();
            superknight.Move();

            //EnterGame(mage);
        }
    }
}

// 오버라이딩 - 타입에 따라서 다르게 함수가 작동하도록 하는 문법.
// (virtual, override)