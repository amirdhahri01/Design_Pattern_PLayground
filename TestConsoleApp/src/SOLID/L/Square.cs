using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp.src.SOLID.L{
    public class Square:Rectangle
    {
        public override double width{
            get => base.width;
            set => base.width = base.height = value;
        }
        public override double height{
            get => base.height;
            set => base.height = base.width = value;
        }
    }

}