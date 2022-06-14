using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Car
    {
        private string model = "PMODEL";
        public string handle = "ABCMODEL";

        private string modelCarcenter = "PMODEL";

        public void getModel()
        {
            Console.WriteLine(model);
        }

        public void getModel2()
        {
            Console.WriteLine(handle);
        }

    }
}
