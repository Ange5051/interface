using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main()
        {
            try
            {
                IShare triangle = new Triangle(4, 7, 6);
                IShare disk = new Disk(4);

                ShapePrinter.PrintShapeInfo(triangle);
                ShapePrinter.PrintShapeInfo(disk);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            Console.ReadKey();
        }
    }
}
