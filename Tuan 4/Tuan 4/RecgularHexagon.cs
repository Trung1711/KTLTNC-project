using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan_4
{
    class RecgularHexagon: Shape,IPoint
    {
        public RecgularHexagon(string name= "NoName") : base(name)
        {
            Name = name;
        }
        public RecgularHexagon(string name, double edge)
        {
            Name = name;
            Edge = edge;
        }
        public double Edge { get; set; }
        public byte Points { get { return 6; } }
        public override double CalculatePerimeter()
        {
            //throw new Exception("not implemented");
            return 6* Edge;
        }
        public override double CalculateArea()
        {
            return 2.598 * Edge*Edge;
        }
        

    }
}
