using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 단항연산자
            //int a = 5;
            //a++; // 1을 더해줌
            //Console.WriteLine(a);

            // 이항연산자
            //int a = 5;
            //int b = 3;
            //int c = 0;

            ////c = a - b;
            //c = a + b;
            //Console.WriteLine(c);

            // 삼항연산자
            //int c = (5 > 3) ? 2 : 0;
            //Console.WriteLine(c);

            // 대입연산자
            //int a = 5;
            //int b = 6;
            //b = a; //b에도 5 값이 저장
            //string str = "b" + "gst" + b;
            //Console.WriteLine(str);

            // 산술연산자
            // 덧셈 연산자
            //int a = 5;
            //int b = 6;
            //int c = a + b;
            //Console.WriteLine(c);

            // 빼기 연산자
            //int a = 3;
            //int b = 6;
            //int c = a - b;
            //Console.WriteLine(c);

            // 곱셈 연산자
            //int a = 5;
            //int b = 6;
            //int c = a * b;
            //Console.WriteLine(c);

            // 나눗셈 연산자
            //int a = 5;
            //int b = 6;
            //int c = a / b;
            //Console.WriteLine(c);  // 값은 0.8333333...

            // 나머지 연산자
            //int a = 5;
            //int b = 2;
            //int c = a % b; // 몫이 2 , 나머지는 1이 출력된다.
            //Console.WriteLine(c);


            // 증감 연산자
            //int a = 5;
            //a++;
            //Console.WriteLine(a++);

            //int a = 5;
            //Console.WriteLine(a++);

            //int a = 5;
            //Console.WriteLine(a++);
            //Console.WriteLine(a);

            //int a = 5;
            //Console.WriteLine(++a);
            //Console.WriteLine(a);

            // 복합대입연산자
            //int a = 5;
            //a += 3; // a = a+3;
            //Console.WriteLine(a);

            //int a = 5;
            //a -= 3; // a = a-3;
            //Console.WriteLine(a);

            //int a = 5;
            //a *= 3; // a = a*3;
            //Console.WriteLine(a);

            //int a = 5;
            //a /= 3; // a = a/3;
            //Console.WriteLine(a);

            // 비교연산자
            //int a = 5;
            //int b = 6;
            //bool result = (a == b);
            //Console.WriteLine(result);

            //int a = 5;
            //int b = 5;
            //bool result = (a == b);
            //Console.WriteLine(result);

            //int a = 5;
            //int b = 6;
            //bool result = (a != b);
            //Console.WriteLine(result);

            //int a = 5;
            //int b = 6;
            //bool result = a > b;
            //Console.WriteLine(result);

            // 조건 연산자
            //int a = 3;
            //int b = 4;
            //string c = (a > b) ? "참입니다." : "거짓입니다.";
            //Console.WriteLine(c);

            //int a = 3;
            //int b = 4;
            //string c = (a < b) ? "참입니다." : "거짓입니다.";
            //Console.WriteLine(c);

            // 논리연산자
            //if (true)
            //{
            //    Console.WriteLine("참 일경우에민 이 코드 실행");
            //}
            //else
            //{
            //    Console.WriteLine("거짓 일경우에만 이 코드 실행");
            //}

            // AND 연산자
            //bool result = true;
            //bool result2 = true;
            //////!
            //Console.WriteLine(!result && result2);

            // OR 연산자
            //bool result = true;
            //bool result2 = true;
            //////!
            //Console.WriteLine(!result || result2);

            // 비트 연산자
            // 비트 연산자는 2진수로 계산
            //int a = 1; // 0001
            //int b = 5; // 0101
            //int c = 0; // 0000
            //Console.WriteLine(a & b);

            //int a = 1; // 0001
            //int b = 5; // 0101
            //int c = 0; // 0000
            //Console.WriteLine(a | b);

            //int a = 1; // 0001
            //int b = 5; // 0101
            //int c = 0; // 0000
            //Console.WriteLine(a ^ b);

            //int a = 1; // 0001
            //int b = 5; // 0101
            //a = a << 2;
            //Console.WriteLine(a);

            //int a = 1; // 0001
            //int b = 5; // 0101
            //a = a >> 2;
            //Console.WriteLine(a);

            //int a = 1; // 0001
            //int b = 5; // 0101
            //b <<= 1;
            //// b = b << 1;
            //Console.WriteLine(b);

            int a = 1; // 0001
            int b = 5; // 0101
            b <<= 2;
            // b = b << 1;
            Console.WriteLine(b);

        }
    }
}
