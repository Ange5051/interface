using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    public interface IShare
    {
        double Perimeter();
        double Area();
        string Name { get; }
        string Parameters { get; }
    }
}
