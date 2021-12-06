using System;
using System.Collections.Generic;
using System.Text;

namespace MultipleInheritance
{
    public class Scanner : IScanner
    {
        public void Scan() { Console.WriteLine("Scan In Action"); }

    }
}
