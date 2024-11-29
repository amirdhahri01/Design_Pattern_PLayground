using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp.src.SOLID.D
{
    public class Car 
    {
        private Engine engine;
       public Car(){
           engine = new Engine(); 
       }
       public void StartCar(){
            engine.Start();
            System.Console.WriteLine("Car Started");
       }
    }
}