﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //반복문 응용
            //중첩 for문
            for(int i = 0; i < 6; i++)
            {
                for(int k = 0; k < 6; k++)
                {
                    Console.WriteLine(i + ", " + k);
                }
            }
        }
    }
}
