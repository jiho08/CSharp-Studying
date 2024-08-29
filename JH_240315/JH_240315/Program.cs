using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JH_240315
{
    class Program
    {
        static void Main(string[] args)
        {
            byte by = 255;

            int x = 30;
            object y = 20;

            Console.WriteLine("F:\\2024\\수업 자료\\[강의] C# 프로그래밍");
            Console.WriteLine(Console.Read());

            string str = Console.ReadLine();
            float input4 = float.Parse(Console.ReadLine());

            int a = 5;
            // a의 값은 ~ 여기에 10을 더하면 ~ 입니다.
            // 1. +
            Console.WriteLine("a의 값은" + a);

            // 2. $
            Console.WriteLine($"\"a의 값은 {a} 여기에 10 더하면 \"");

            // 3. {0} {1}, a, a + 10
            Console.WriteLine("a의 값은 {0} 10 더하면 {1}", a, a + 10);
        }
    }
}
