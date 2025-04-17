using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class MyClass : IInterface
    {
        public double MyGetPI()
        {
            return Math.PI;
        }
        public int MyGetInt()
        {
            return 50;
        }
        public int MySquare(int x)
        {
            return (int)(x * x);
        }
        public double MySqrt(double x)
        {
            return (double)Math.Sqrt(x);
        }
    }
}
