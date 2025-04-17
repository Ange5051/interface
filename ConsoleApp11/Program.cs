using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            Console.WriteLine($"{myClass.MyGetPI()}");
            Console.WriteLine($"{myClass.MyGetInt()}");
            Console.WriteLine($"{myClass.MySquare(3)}");
            Console.WriteLine($"{myClass.MySqrt(9)}");
            Console.ReadKey();
        }
    }
}
