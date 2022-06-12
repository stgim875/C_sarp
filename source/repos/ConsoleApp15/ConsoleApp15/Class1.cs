using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Class1
    {
        public int addNumber(int a, int b)
        {
            int c = a + b;
            return c;
        }
        public void soundFunction()
        {
            Console.WriteLine("소리를냅니다.");
            Console.WriteLine("소리를냅니다.");
        }

        public void readNumber(int a)
        {
            Console.WriteLine("숫자를 출력해주는 함수입니다." +a);
        }
    }
}
