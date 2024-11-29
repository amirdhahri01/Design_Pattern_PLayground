using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp.src.OopPrinciples.Composition{
    public class Car 
    {
        private Engine engine = new Engine();
        private Chassis Chassis = new Chassis();
        private Seats seats = new Seats();
        private Wheels wheels = new Wheels();
        public void StartCar(){
            engine.Start();
            wheels.Rotate();
            Chassis.Support();
            seats.Sit();
            System.Console.WriteLine("Car started...");
        }
    }
}
