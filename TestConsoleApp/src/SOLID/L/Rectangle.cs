using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp.src.SOLID.L{
    public abstract class Rectangle:Shape
    {
        public virtual double width{get;set;}
        public virtual double height{get;set;}
        public override double Area => width*height;
    }

}