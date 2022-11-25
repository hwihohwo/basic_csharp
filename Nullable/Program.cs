using System;

namespace Nullable_
{
    class Program
    {
        static int Find()
        {

            return (0);
        }

        class Monster
        {
            public int Id { get; set; }
        }

        static void Main(string[] args)
        {
            // Nullble -> Null + able
            int? number = null;

            int b = number ?? 0; // number가 null이면 0을 넣어준다.
            Console.WriteLine(b);

            Monster monster = null;

            if (monster != null)
            {
                int monsterId = monster.Id;
            }

            int? id = monster?.Id;
            // 같은 의미
            if (monster == null)
            {
                id = null;
            }
            else
            {
                id = monster.Id;
            }
        }
    }
}