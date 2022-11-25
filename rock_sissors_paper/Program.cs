using System;

namespace rock_sissors_paper
{
    class Program
    {
        enum Choice
        {
            Rock = 1,
            Paper = 2,
            Scissors = 0
        }

        static void Main(string[] args)
        {

            Random rand = new Random();
            int aiChoice = rand.Next(0, 3); // 0~2사이의 랜덤 값
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case (int)Choice.Scissors:
                    Console.WriteLine("가위입니다.");
                    break;
                case (int)Choice.Rock:
                    Console.WriteLine("바위입니다.");
                    break;
                case (int)Choice.Paper:
                    Console.WriteLine("보입니다.");
                    break;
            }

            switch (aiChoice)
            {
                case (int)Choice.Scissors:
                    Console.WriteLine("컴퓨터의 선택은 가위입니다.");
                    break;
                case (int)Choice.Rock:
                    Console.WriteLine("컴퓨터의 선택은 바위입니다.");
                    break;
                case (int)Choice.Paper:
                    Console.WriteLine("컴퓨터의 선택은 보입니다.");
                    break;
            }

            if (choice == (int)Choice.Scissors && aiChoice == (int)Choice.Rock)
                Console.WriteLine("패배하였습니다.");
            else if (choice == (int)Choice.Scissors && aiChoice == (int)Choice.Paper)
                Console.WriteLine("승리하였습니다.");
            else if (choice == (int)Choice.Rock && aiChoice == (int)Choice.Paper)
                Console.WriteLine("패배하였습니다.");
            else if (choice == (int)Choice.Rock && aiChoice == (int)Choice.Scissors)
                Console.WriteLine("승리하였습니다.");
            else if (choice == (int)Choice.Paper && aiChoice == (int)Choice.Scissors)
                Console.WriteLine("패배하였습니다.");
            else if (choice == (int)Choice.Paper && aiChoice == (int)Choice.Rock)
                Console.WriteLine("승리하였습니다.");
            else
                Console.WriteLine("무승부입니다.");
        }
    }
}