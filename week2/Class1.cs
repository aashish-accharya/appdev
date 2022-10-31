using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace test
{
    internal class Class1
    {
        public static void Check(int num1, int num2)
        {
            if (num1 > num2)
            {
                Console.WriteLine($"{num1} + is greater than  + {num2}");
            }
            else if (num1 < num2)
            {
                Console.WriteLine($"{num2} +  is greater than  + {num1}");
            }
            else {
                Console.WriteLine("The number are equal or invalid");
            }
        }

        public static void Print(int y) {
            var x = 1;
            while (x <= y) { 
                Console.Write(x);
                Console.Write(" ");
                x++;
            }
        }

        public static void valid() {
            string secret = "xdd";
            string? password;
            do
            {
                Console.Write("Type your password: ");
                password = Console.ReadLine();

            } while (password != secret);
            Console.WriteLine("Password valid");
        }

        public static void CheckFor() {
            int[] number = {1,2,3,4,5};

            for (int i = 0; i<number.Length; i++) {
                Console.Write(number[i]);
            }
            Console.WriteLine();
            foreach (int num in number) { 
                Console.WriteLine(num);
            }
        }
    }
}
