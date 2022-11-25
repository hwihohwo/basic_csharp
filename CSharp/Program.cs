using System;

namespace CSharp
{
    class Program
    {
        // 여기에 주석을 달 수 있어요
        static void Main(string[] args)
        {
            // 데이터 + 로직
            // 체력 0

            // 윈도우 계산기에 개발자용 계산기가 있다!
            // 0b11111111 = 255(부호없을때)
            // byte(1바이트 0~255 양수만), short(2바이트 -3만~3만), int(4바이트 -21억~21억), long(8바이트)
            // sbyte(1바이트 -128~127), ushort(2바이트 0~6만), uint(4바이트 0~43억), ulong(8바이트)
            int hp;
            short level = 100;
            //메모리를 효율적으로 관리하기 위해 적절한 형식 필요. but 대부분은 int
            long id; //id계통에서는 long을 사용하는것이 더 좋음.

            hp = 100;

            hp = 100 + 1;
            
            byte attack = 0;
            attack--; //언더플로우

            // 10진수
            // 0 1 2 3 4 5 6 7 8 9
            // 10

            // 2진수
            // 0~1
            // 0b00 0b01 0b10 0b11 0b100
            // 0b10001111 = 0x8F(숫자 4개 기준으로 변환하면 됨).

            // 16진수
            // 0~9 a b c d e f
            // 0x00 0x01 0x02 .. 0x0F
            // 0x10

            // 1바이트(참/거짓)
            bool b;

            b = true;// 1
            b = false;// 0

            // 소수
            // 4바이트
            float f = 3.14f;// 7자리 정도까지 정밀함.

            // 8바이트
            double d = 3.14;

            // 2바이트
            char c = 'a';
            string str = "Hello World";// char의 집합

            // 형식변환

            // 1. 바구니 크기가 다른 경우!
            int a = 1000;
            short b = (short)a;

            Console.WriteLine(str);
            // 여기에 주석을 달 수 있어요
            Console.WriteLine("Hello Number ! {0}", attack);
        }
    }
}