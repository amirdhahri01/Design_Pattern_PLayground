using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp.src.OopPrinciples.Polymorphism{
    public class Bike : Vehicle
    {
        public int numberOfDoors{get; set;}
        public int numberOfWheels{get; set;}
        public void start(){
            System.Console.WriteLine("Bike is starting...");
        }
        public void stop(){
            System.Console.WriteLine("Bike is stopping...");
        }
    }
}