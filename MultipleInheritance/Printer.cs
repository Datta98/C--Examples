using System;
using System.Collections.Generic;
using System.Text;

namespace MultipleInheritance
{
    public class Printer : IPrinter
    {
        public void Print() { Console.WriteLine("Print in Action"); }
    }
}
