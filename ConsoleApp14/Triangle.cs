using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    public class Triangle : IShare
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public string Name => "Треугольник";
        public string Parameters => $"Стороны: A = {A}, B = {B}, C = {C}";

        public Triangle(double a, double b, double c)
        {
            if (a + b <= c || a + c <= b || b + c <= a)
                throw new ArgumentException("Такой треугальник не бывает");

            A = a;
            B = b;
            C = c;
        }

        public double Perimeter()
        {
            return A + B + C;
        }

        public double Area()
        {
            double p = Perimeter() / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C)); 
        }
    }
}
