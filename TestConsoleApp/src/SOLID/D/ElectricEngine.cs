using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp.src.SOLID.D
{
    public class ElectricEngine : IEngine
    {
        public void Start(){
            System.Console.WriteLine("ElectricEngine Started");
        }
    }
}