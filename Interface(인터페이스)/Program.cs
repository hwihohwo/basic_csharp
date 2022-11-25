using System;

namespace Interface
{
    class Program
    {
        abstract class Monster
        {
            public abstract void Shout();
        }

        interface IFlyable
        {
            void Fly();
        }

        class Orc : Monster
        {
            public override void Shout()
            {
                Console.WriteLine("록타르 오가르!");
            }
        }
       
        class FlyableOrc : Orc, IFlyable
        {
            public void Fly()
            {

            }
        }

        class Skeleton : Monster
        {
            public override void Shout()
            {
                Console.WriteLine("꾸에에에엑!");
            }
        }

        static void DoFly(IFlyable flyable)
        {
            flyable.Fly();
        }

        static void Main(string[] args)
        {
            IFlyable flyable = new FlyableOrc();
            DoFly(flyable);
        }
    }
}