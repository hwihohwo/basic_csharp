using System;

namespace Property
{
    class Program
    {
        class Knight
        {
            public int Hp { get; set; } = 100;// 자동완성 프로퍼티

            //private int hp;

            //public int Hp
            //{
            //    get { return hp; }
            //    set { hp = value; }
            //}
        }

        static void Main(string[] args)
        {
            // 프로퍼티
            Knight knight = new Knight();
            knight.Hp = 100;

            int hp = knight.Hp;
        }
    }
}