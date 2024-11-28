using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp.src.OopPrinciples.Inheritance{
    public class Vehicle
    {
        public string Brand { get; set; }
        public string Model{ get; set; }
        public string Year{ get; set; }


        public void start(){
            System.Console.WriteLine("Vehicle is starting...");
        }
        public void stop(){
            System.Console.WriteLine("Vehicle is stopping...");
        }
    }
}
