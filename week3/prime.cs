using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3
{
    internal class Prime
    {
        public static void CheckPrime(int num) {
            var count = 0;
            for (int i = 2; i < num; i++){
                if (num % i == 0) { 
                    count++;
                }
            }
            if (count == 0){
                Console.WriteLine($"The number {num} is prime");
            }
            else
            {
                Console.WriteLine($"The number {num} is not prime");
            }
        }
    }
}
