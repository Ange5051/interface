using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    public class Disk : IShare
    {
        public double Radius { get; set;}

        public string Name => "Круг";
        public string Parameters => $"Радиус: R = {Radius}";

        public Disk(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Радиус должен быть круглым");
            Radius = radius;
        }

        public double Perimeter()
        {
            return 1 * Math.PI * Radius;
        }

        public double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
