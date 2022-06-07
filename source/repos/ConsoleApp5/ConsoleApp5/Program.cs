using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4강 배열
            //1차원 배열
            //int[] a = { 1, 2, 3, 4 };
            //string[] vars = { "파인애플", "사과", "바나나" };

            //위치
            //Console.WriteLine(vars[0]);
            //Console.WriteLine(vars[1]);
            //Console.WriteLine(vars[2]);

            //배열의 길이를 얻고자 할 때는
            //Console.WriteLine(vars.Length);

            //마지막 요소만 뽑고 싶을 때(총3개의 요소인데 즉, 3-1=2인 상황)
            //Console.WriteLine(vars[vars.Length - 1]);

            //2차원 배열 -> 1차원 배열을 여러개 가질 수 있다. 3차원 배열 -> 2차원 배열을 여러개가질 수 있다.
            //앞 뒤 배열의 갯수가 동일해야 한다.
            //int[,] abc = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 } };
            //Console.WriteLine(abc[0, 2]);
            //Console.WriteLine(abc[1, 1]);

            //가변배열
            int[][] ab = new int[3][];
            ab[0] = new int[4];
            ab[1] = new int[4];
            ab[2] = new int[3];
            //int[,] abc = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11 } };
            ab[2][2] = 4;
            ab[0][0] = 4;

            Console.WriteLine(ab[0][1]);
            Console.WriteLine("길이는?"+ab.Length);

        }
    }
}
