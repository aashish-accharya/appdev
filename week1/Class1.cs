using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1
{
    public class class1
    {
        public static void Addition()
        {
            Console.WriteLine("Enter a number: ");
            var a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a);
        }

        public static void StringInterpol()
        {
            Console.WriteLine("Enter your first name");
            var firstName = Console.ReadLine();

            Console.WriteLine("Enter your last name ");
            var lastName = Console.ReadLine();

            Console.WriteLine($"Hello, {firstName} {lastName}");
        }
    }
}
