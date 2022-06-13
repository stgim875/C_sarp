using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //예외처리
            //string a = "";
            //Console.ReadLine();

            try
            {
                //try 오류가 발생할 가능성이 높거나 중요.
                int[] asd = { 0, 1, 2, 3 };
                Console.WriteLine(asd[4]);
            }
            catch(IndexOutOfRangeException e)
            {
            }

            catch(Exception e)
            {
                //catch문은 오류가 발생했을 때 처리
                Console.WriteLine("오류가 발생했을때 실행되는 영역2");
                Console.WriteLine(e.ToString());
            }
            finally
            {
                Console.WriteLine("오류가 발생하거나, 오류가 발생하지 않아도 실행되는 영역");
                Console.WriteLine("오류가 발생하거나, 오류가 발생하지 않아도 실행되는 영역");
            }

            void gst()
            {
                try
                {
                    Console.WriteLine("오류가 발생하거나, 오류가 발생하지 않아도 실행되는 영역");
                    Console.WriteLine("오류가 발생하거나, 오류가 발생하지 않아도 실행되는 영역");
                    Console.WriteLine("오류가 발생하거나, 오류가 발생하지 않아도 실행되는 영역");
                    Console.WriteLine("오류가 발생하거나, 오류가 발생하지 않아도 실행되는 영역");
                    Console.WriteLine("오류가 발생하거나, 오류가 발생하지 않아도 실행되는 영역");
                    Console.WriteLine("오류가 발생하거나, 오류가 발생하지 않아도 실행되는 영역");
                    Console.WriteLine("오류가 발생하거나, 오류가 발생하지 않아도 실행되는 영역");
                    Console.WriteLine("오류가 발생하거나, 오류가 발생하지 않아도 실행되는 영역");
                    Console.WriteLine("오류가 발생하거나, 오류가 발생하지 않아도 실행되는 영역");
                    Console.WriteLine("오류가 발생하거나, 오류가 발생하지 않아도 실행되는 영역");
                    Console.WriteLine("오류가 발생하거나, 오류가 발생하지 않아도 실행되는 영역");
                    Console.WriteLine("오류가 발생하거나, 오류가 발생하지 않아도 실행되는 영역");
                    Console.WriteLine("오류가 발생하거나, 오류가 발생하지 않아도 실행되는 영역");
                    Console.WriteLine("오류가 발생하거나, 오류가 발생하지 않아도 실행되는 영역");
                }
                catch (Exception e)
                {
                    //catch문은 오류가 발생했을 때 처리
                    Console.WriteLine("오류가 발생했을때 실행되는 영역");
                    Console.WriteLine(e.ToString());
                }
                //int c = Int32.Parse(a);
                //Console.WriteLine(asd[c]);

                //Console.WriteLine(asd[Int32.Parse(a)]);
            }
        }
    }
}
