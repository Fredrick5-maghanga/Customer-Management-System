using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal partial class Program
}

namespace inheritance
{
    public class Rectangle
    {
        public virtual int Height { get; set; }
        public virtual int Width { get; set; } 
    }
    public class AreaCalculator
    {
        public static int calculateArea(Rectangle r)
        {
            return r.Height*r.Width;
        }
        public class Square
        {
            public  int Side { get; set; }    
            public override int Height { get => base.Height;
                    {
                    get { return_height;}
                    set
                        {
                        _height = value;
                        _height = value;
                       
                    }
                }
                //width implemented simmilarly
        }
    }
}

