using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    public static class ShapePrinter
    {
        public static void PrintShapeInfo(IShare shape)
        {
            Console.WriteLine($"Фигура: {shape.Name}");
            Console.WriteLine($"Параметры: {shape.Parameters}");
            Console.WriteLine($"Периметр: {shape.Perimeter():F2}");
            Console.WriteLine($"Площадь: {shape.Area():F2}");
            Console.WriteLine(new string('-', 40));
        }
    }
}
