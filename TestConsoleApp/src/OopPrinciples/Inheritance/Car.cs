using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp.src.OopPrinciples.Inheritance{
    public class Car : Vehicle
    {
        public int numberOfDoors{get; set;}
        public int numberOfWheels{get; set;}
        public override void start(){
            System.Console.WriteLine("Car is starting...");
        }
        public override void stop(){
            System.Console.WriteLine("Car is stopping...");
        }
    }
}
