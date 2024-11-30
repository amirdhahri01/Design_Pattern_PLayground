using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp.src.DesignPatterns.Behavioral.Strategy.GoodExample
{
    public class CompressorWEBM : ICompressor
    {
        public void Compress(){
            System.Console.WriteLine("Compressing video using WEBM");
        }    
        public string GetExtension(){
            return "WEBM";
        }
    }
}
