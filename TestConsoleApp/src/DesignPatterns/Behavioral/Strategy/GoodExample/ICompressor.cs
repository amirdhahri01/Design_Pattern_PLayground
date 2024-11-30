using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp.src.DesignPatterns.Behavioral.Strategy.GoodExample
{
    public interface ICompressor
    {
        void Compress();
        string GetExtension();
    }
}
