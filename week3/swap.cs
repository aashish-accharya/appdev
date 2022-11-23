using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3
{
    internal class Swap
    {
        public static void swap(int num1, int num2) {
            int temp;
            Console.WriteLine($"Current number sequence: {num1}, {num2}");
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine($"Final number sequence: {num1}, {num2}");
        }
    }
}
