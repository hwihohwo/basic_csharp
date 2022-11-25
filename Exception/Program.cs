using System;

namespace Exception_
{
    class Program
    {
        class TestException : Exception
        {

        }

        static void Main(string[] args)
        {
            try
            {
                // 1. 0으로 나눌 때
                // 2. 잘못된 메모리를 참조 (null)
                // 3. 오버플로우
                //int a = 10;
                //int b = 0;
                //int result = a / b;
                ////예외 발생하면 이 후 코드 실행 안됨.
                //int c = 0;
                throw new TestException();
            }

            catch (DivideByZeroException e)
            {

            }

            catch (Exception e)
            {

            }

            finally // 예외 발생해도 실행이 되는 코드.
            {

            }
        }
    }
}
