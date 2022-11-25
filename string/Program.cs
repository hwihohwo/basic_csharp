using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Harry Potter";

            //1. 찾기
            bool found = name.Contains("Harry");
            int index = name.IndexOf('z');

            //2. 변형
            name = name + " Junior";

            string lowerCaseName = name.ToLower();
            string upperCaseName = name.ToUpper();
            Console.WriteLine(lowerCaseName);
            Console.WriteLine(upperCaseName);

            string newName = name.Replace('r', 'l');
            Console.WriteLine(newName);

            //3. 분할
            string[] names = name.Split(new char[] { ' ' });
            string substringName = name.Substring(5);
        }
    }
}