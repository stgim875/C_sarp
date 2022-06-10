using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //조건문_2
            int week = 4;

            switch(week)
            {
                case 1:
                    Console.WriteLine("월요일");
                    break;

                case 2:
                    {
                        Console.WriteLine("화요일");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("수요일");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("목요일");
                        break;
                    }
                default:
                    Console.WriteLine("어느 것에도 해당이 안됩니다");
                    break;

            }

        }
    }
}
