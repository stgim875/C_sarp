using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //반복문
            //for & each
            string[] strs = { "바나나", "사과", "파인애플", "망고" };
            foreach (string i in strs)
            {
                Console.WriteLine(i);
            }

            //위 코드와 동일항 동작을한다. 
            for (int i = 0; i < strs.Length; i++)
            {
                Console.WriteLine(strs[i]);
            }
        }
    }
}
