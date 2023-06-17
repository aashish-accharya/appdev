using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week4;

namespace Test2
{
    public class Class3 : Class1
    {
        Class1 obj1 = new Class1();

        public void display() {
            string res = obj1.Test1();
            Console.WriteLine(res);
        }
    }
}
