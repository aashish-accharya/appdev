using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Principles
{
    internal class Dry
    {
        public static void Violation(string message) {
            Console.WriteLine(message);
        }

        public static void Compliance(List<string> values) { 
            foreach (string value in values)
            {
                Console.WriteLine(value);
            }
        }
    }
}
