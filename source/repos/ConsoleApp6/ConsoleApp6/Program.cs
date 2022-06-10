using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //조건문_1
            //int a = 5;
            //int b = 10;

            //Console.WriteLine(a < b);

            ////연산자를 이용하여 참과 거짓을 얻을 수 있다.
            //if(a > b)
            //{
            //    //if문이 참일 때 실행됩니다.
            //    Console.WriteLine("if문 실행");
            //}

            //==========================================================
            //int a = 5;
            //int b = 10;

            //Console.WriteLine(a > b);

            ////연산자를 이용하여 참과 거짓을 얻을 수 있다.
            //if(a > b)
            //{
            //    //if문이 참일 때 실행됩니다.
            //    Console.WriteLine("if문 실행");
            //}
            //else //else로 분기를 할 수 있다.
            //{
            //    //if문이 참일 때 실행됩니다.
            //    Console.WriteLine("else문 실행");

            //}

            int a = 5;
            int b = 10;

            Console.WriteLine(a > b);

            //연산자를 이용하여 참과 거짓을 얻을 수 있다.
            if (a > b) //a < 1 거짓
            {
                Console.WriteLine("1");
            }
            else if(a <3) //a < 3 거짓
            {
                Console.WriteLine("3");
            }
            else if (a <7) //a < 3 보다 크고 a < 7 보다 작다라는 것을 유추 할 수 있고 조건에 해당이되면 이 코드를 실행
            {
                Console.WriteLine("7");
            }

            else if (a < 9) //a < 9 참
            {
                Console.WriteLine("9");
            }
            else
            {

            }
 

        }
    }
}
