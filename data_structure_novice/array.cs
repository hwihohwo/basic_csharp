using System;

namespace data_structure_novice
{
    class Player
    {

    }

    class Monster
    {

    }

    class array
    {
        Player player;
        Monster monster;

        static int GetHighestScore(int[] scores)
        {
            int ret;

            ret = scores[0];
            foreach(int i in scores)
            {
                if (i > ret)
                    ret = i;
            }
            return (ret);
        }

        static int GetAverageScore(int[] scores)
        {
            if (scores.Length == 0)
                return (0);
            int ret;

            ret = 0;
            foreach(int i in scores)
            {
                ret += i;
            }
            return (ret /= scores.Length);
        }

        static int GetIndexOf(int[] scores, int value)
        {
            for(int i = 0; i < scores.Length; i++)
            {
                if (value == scores[i])
                    return (i);
            }

            return (-1);
        }

        static void Sort(int[] scores)
        {
            int temp;

            for (int i = 0; i < scores.Length - 1; i++)
            {
                for (int j = i + 1; j < scores.Length; j++)
                {
                    if (scores[i] > scores[j])
                    {
                        temp = scores[i];
                        scores[i] = scores[j];
                        scores[j] = temp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            // 배열
            int[] scores = /*new int[]*/ { 10, 30, 40, 20, 50 };

            Console.WriteLine(GetHighestScore(scores));
            Console.WriteLine(GetAverageScore(scores));
            Console.WriteLine(GetIndexOf(scores, 50));
            Sort(scores);
            foreach(int i in scores)
            {
                Console.WriteLine(i);
            }
        }
    }
}