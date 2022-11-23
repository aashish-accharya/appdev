using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3
{
    internal class Search
    {
        public static void SearchVal(int num) {
            int[] array1 = {1,2,3,4,5,6,7,8,12,642,1312};

            Console.Write("Array = ");
            foreach (int i in array1) { 
                Console.Write(i);
                Console.Write(" ");
            }

            Console.WriteLine();
            foreach (int i in array1) {
                if (array1[i] == num) { 
                    Console .WriteLine($"The number {num} is in array");
                }
            }

        }
    }
}
