using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //반복문
            //while
            int i = 0;
            while (i < 6) //i가 6미만일 때 반복해서 while 중괄호안에 있는 코드가 실행이된다.
            {
                Console.WriteLine("i의 값은?" + i);
                i++;
            }
            Console.WriteLine("반복문이 끝");
            //while(조건)
            //{
            //    조건이 참일 경우만 코드가 실행됩니다. 반복해서  실행
            //}

        }
    }
}
