using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass dClass = new DerivedClass();
            dClass.Method1();
            dClass.Method2();
            dClass.Method3();
            Console.ReadLine();
        }
    }
}
