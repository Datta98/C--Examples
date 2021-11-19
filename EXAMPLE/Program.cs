using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            double i = 34.5;
            object iBoxed = i;
            int? jNullable = 42;
            if (iBoxed is double a && jNullable is int b)
            {
                Console.WriteLine(a + b);  // output 76
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Invalid datatype");
                Console.ReadKey();
            }
        }
    }
}
