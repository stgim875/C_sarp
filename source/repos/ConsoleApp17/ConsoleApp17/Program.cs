using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //객체지향
            //class 생성
            Car car = new Car();
            Car car2 = new Car();
            car.getModel();
            car2.getModel();

            car.handle = "ABC1000";
            car.getModel2();

            car2.getModel2();
        }
    }
}
