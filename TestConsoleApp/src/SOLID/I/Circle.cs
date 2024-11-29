using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp.src.SOLID.I
{
    public class Circle : IShape2D
    {
        public double Radius{get;set;}
        public double Area()
        {   
            return Math.PI * Radius * Radius;
        }
    }
}