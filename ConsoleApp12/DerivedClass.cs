using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class DerivedClass : IInterface3
    {
        public void Method1()
        {
            Console.WriteLine($" ета перший метод");
        }
        public void Method2()
        {
            Console.WriteLine($" другий метод");
        }
        public void Method3()
        {
            Console.WriteLine($" Третий метод");
        }
    }
}
