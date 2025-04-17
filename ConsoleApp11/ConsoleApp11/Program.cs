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
            Console.WriteLine($"Метод, возвращающий число PI - {myClass.MyGetPI()}");
            Console.WriteLine($"Метод, возвращающий число типа int - {myClass.MyGetInt()}");
            Console.WriteLine($"Метод, возвращающий x в квадрате - {myClass.MySquare(3)}");
            Console.WriteLine($"Метод, возвращающий корень квадратный из x - {myClass.MySqrt(9)}");
            Console.ReadKey();
        }
    }
}
