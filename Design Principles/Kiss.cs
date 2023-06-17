using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Principles
{
    internal class Kiss
    {
        public static void FailMultiply(int x, int y) {
            int result = y;
            for (int i = 0; i < x; i++) {
                result = y * y;
            }
            Console.WriteLine(result);
        }
    }
}
