using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3
{
    internal class OddEven
    {
        public static void CheckOddEven(int num)
        {
            if (num <= 0) {
                Console.WriteLine("Invalid Input Try Again");
                return;
            }
            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} is even");
            }
            else {
                Console.WriteLine($"{num} is odd");
            }
        }
    }
}
