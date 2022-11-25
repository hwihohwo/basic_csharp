using System;

namespace Dictionary
{
    class Program
    {
        class Monster
        {
            public Monster(int id) { this.id = id; }
            public int id;
        }

        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            //Hashtable로 구현되어 있음.
            // 메모리 손해.
            // [ 메모리를 내주고, 성능을 취한다 ! ]

            // Dictionary

            Dictionary<int, Monster> dic = new Dictionary<int, Monster>();
            for (int i = 0; i < 10000; i++)
            {
                dic.Add(i, new Monster(i));
            }

            Monster mon;
            bool found = dic.TryGetValue(7777, out mon);

            dic.Remove(7777);
            Console.WriteLine();
        }
    }
}