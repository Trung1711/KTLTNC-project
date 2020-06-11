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
        public override double CalculatePerimeter()
        {
            //throw new Exception("not implemented");
            return 0;
        }
        public override double CalculateArea()
        {
            return Edge*Edge*6;
        }
        public byte Points { get { return 4; } }

    }
}
