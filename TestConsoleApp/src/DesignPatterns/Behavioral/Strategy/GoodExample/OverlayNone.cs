using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp.src.DesignPatterns.Behavioral.Strategy.GoodExample
{
    public class OverlayNone : IOverlay
    {
        public void Applay(){
            System.Console.WriteLine("Not applaying an overlay");
        }    
    }
}
