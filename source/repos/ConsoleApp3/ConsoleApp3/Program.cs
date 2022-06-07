using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2강 변수
            //주석 단축키 : Ctrl + K + C(순차적으로 눌러야 함)
            //주석 해제 단축키 : Ctrl + C + U(순차적으로 눌러야 함)
            //코드 찾기 : Ctrl + F
            //저장 : Ctrl + S
            //빌드 : Ctrl + Shift + B
            //실행 : Ctrl + F5
            //Ctrl + 화살표(단어 이동)

            //string schoolstdnt = "a";
            //int num = -5; // 정수
            //int num2 = 5; // 정수
            //long bignum = 10000000000000L;  // L을 추가하여 Long을 뜻함
            //short smallnum = 5000;
            //byte smallmum2 = 250;
            //bool logic = true; // 참, 진실
            //bool logic2 = false; // 거짓
            
            //string strsdf = "abc";
            //char str1 = 'a'; // 문자열 하나만 저장하고 싶다면...
            //float flt = 0.5F; // 실수 소수점 사용, 단). 실수 뒤에 반드시 F를 붙여야한다.
            //double doublenum = 0.5555555555555555d; // 큰 숫자를 사용 할 때 뒤에 반드시 D를 붙여야한다.

            int a = 5;
            int b = 6;
            b = a; // b에 a값을 저장
            //형변환을 통해 문자 타입에 숫자를 저장하는 방법
            string c = ""; 
            c = a.ToString(); // 함수를 통해서 결과를 얻기 
            //string 타입에 5가 저장되어 있음 > int 타입을 num에 저장하고 싶을 때
            int num = Int32.Parse(c);
            //num에 숫자 타입으로 변경해서 저장


            //Console.WriteLine(schoolstdnt);
            //Console.WriteLine(num);
            //Console.WriteLine(num2);
            //Console.WriteLine(bignum);
            //Console.WriteLine(smallnum);
            //Console.WriteLine(smallmum2);

            //// bool은 코드를 분기를 하고자 할 때 많이 사용된다.(if문)
            //Console.WriteLine(logic);
            //Console.WriteLine(logic2);
            
            //Console.WriteLine(strsdf);   
            //Console.WriteLine(str1); // 문자열 하나만 저장하고 싶다면...
            //Console.WriteLine(flt);
            //Console.WriteLine(doublenum);

            Console.WriteLine(b); // b에 a값을 저장
            Console.WriteLine(c);
            Console.WriteLine(num);

        }
    }
}
