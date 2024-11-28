using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp.src.OopPrinciples.Polymorphism{
    public class Vehicle
    {
        public string Brand{ get; set; }
        public string Model{ get; set; }
        public int Year{ get; set; }
        public virtual void start(){
            System.Console.WriteLine("Vehicle is starting...");
        }
        public virtual void stop(){
            System.Console.WriteLine("Vehicle is stopping...");
        }
    }
}
