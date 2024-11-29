using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp.src.SOLID.I
{
    public class Sphere : IShape3D
    {
        public double Radius{get;set;}
        public double Area()
        {   
            return 4 * Math.PI * Radius * Radius;
        }
        public double Volume()
        {
            return (4/3)* Math.PI * Radius * Radius * Radius;
        }
    }
}