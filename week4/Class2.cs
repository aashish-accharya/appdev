using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4
{
    public class Class2 : Class1
    {
        public void Test2()
        {
            Class1 obj = new Class1();
            string result = obj.Test1();
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
