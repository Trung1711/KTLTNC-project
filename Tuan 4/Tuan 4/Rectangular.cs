using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan_4
{
    class Rectangular: Shape,IPoint
    {
        public Rectangular(string name ="NoName"): base(name)
        {
            Name = name;
        }
        public Rectangular(string name, double height, double width)
        {
            Name = name;
            Height = height;
            Width = width;
        }
        public double Height { get; set; }
        public double Width { get; set; }
        public byte Points { get { return 4; } }
        public override double CalculatePerimeter()
        {
            return (Width + Height) * 2;
        }
        public override double CalculateArea()
        {
            return Width*Height;
        }
       
    }
}
