using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1
{
    internal class calc
    { 
        public static void Addition(int num1, int num2)
        {
            int addition = num1 + num2;
            Console.WriteLine($"{num1} + {num2} = {addition}");
        }
        
        public static void Substraction(int num1, int num2)
        {
            int subs = num1 - num2;
            Console.WriteLine($"{num1} - {num2} = {subs}");
        }

        public static void Multiply(int num1, int num2)
        {
            int multiply = num1 * num2;
            Console.WriteLine($"{num1} X {num2} = {multiply}");
        }
        public static void Division(int num1, int num2)
        {
            int div = num1 / num2;
            Console.WriteLine($"{num1} /  {num2} = {div}");
        }

    }
}
