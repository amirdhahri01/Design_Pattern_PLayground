using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp.src.DesignPatterns.Behavioral.Strategy.GoodExample
{
    public class CompressorMP4 : ICompressor
    {
        public void Compress(){
            System.Console.WriteLine("Compressing video using MP4");
        }    
        public string GetExtension(){
            return "MP4";
        }
    }
}
