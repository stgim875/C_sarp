using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Class1

        private string model = "PMODEL";
        public string handle = "ABCMODEL";
        
        public void getModel()
        {
            Console.WriteLine(model);
        }

        public string getModel()
        {
        return model;
        }

        public void getModel2()
        {
            Console.WriteLine(handle);
        }
    
}
