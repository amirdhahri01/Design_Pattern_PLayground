using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp.src.SOLID.D
{
    public class Engine : IEngine
    {
        public void Start(){
            System.Console.WriteLine("Engine Started");
        }
    }
}