using System;

namespace list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < 5; i++)
                list.Add(i);

            //삽입, 삭제
            list.Insert(2, 999);

            list.RemoveAt(0);
            bool success = list.Remove(3);
            list.Clear();

            for (int i = 0; i < list.Count; i++)
                Console.WriteLine(list[i]);

            foreach (int num in list)
                Console.WriteLine(num);
            Console.WriteLine();
        }
    }
}