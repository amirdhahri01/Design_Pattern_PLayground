using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp.src.OopPrinciples.Inheritance{
    public class Bike : Vehicle
    {
        public int numberOfDoors{get; set;}
        public int numberOfWheels{get; set;}
        public override void start(){
            System.Console.WriteLine("Bike is starting...");
        }
        public override void stop(){
            System.Console.WriteLine("Bike is stopping...");
        }
    }
}
