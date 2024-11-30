using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp.src.DesignPatterns.Behavioral.Strategy.GoodExample
{
    public class OverlayBlur: IOverlay
    {
        public void Applay(){
            System.Console.WriteLine("Applaying blur overlay");
        }    
    }
}
