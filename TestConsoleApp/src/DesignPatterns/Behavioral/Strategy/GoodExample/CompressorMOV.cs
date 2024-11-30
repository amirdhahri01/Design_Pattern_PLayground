using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp.src.DesignPatterns.Behavioral.Strategy.GoodExample
{
    public class CompressorMOV : ICompressor
    {
        public void Compress(){
            System.Console.WriteLine("Compressing video using MOV");
        }  
        public string GetExtension(){
            return "MOV";
        }  
    }
}
