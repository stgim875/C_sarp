using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //함수
            int a = 5;
            int b = 6;
            //int c = a + b;
            int c = addNumber(a, b);

            Console.WriteLine(c);
        }

        static int addNumber(int c,int d)
        {
                int a = c + d;
                return a;
        }
    }
}