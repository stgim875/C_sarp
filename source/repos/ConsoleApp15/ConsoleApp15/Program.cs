using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //함수
            int a = 5;
            int b = 6;
            //int c = a + b;
            Class1 class1 = new Class1();
            int c = class1.addNumber(a, b);


            class1.soundFunction();
            class1.readNumber(10);
            Console.WriteLine(c);
        }
    }
}
