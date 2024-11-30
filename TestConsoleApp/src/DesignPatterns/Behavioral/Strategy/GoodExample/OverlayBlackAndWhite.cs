using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp.src.DesignPatterns.Behavioral.Strategy.GoodExample
{
    public class OverlayBlackAndWhite : IOverlay
    {
        public void Applay(){
            System.Console.WriteLine("Applaying black and white overlay");
        }    
    }
}
