using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan_4
{
    class Triangular : Shape, IPoint
    {
        public Triangular(string name="NoName"): base(name)
        {
       
        }
        public Triangular(string name, double edgeA, double edgeB, double edgeC)
        {
            Name = name;
            EdgeA = edgeA;
            EdgeB = edgeB;
            EdgeC = edgeC;
        }
        public double EdgeA { get; set; }
        public double EdgeB { get; set; }
        public double EdgeC { get; set; }
        public byte Points { get { return 3; } }
        public override double CalculatePerimeter()
        {
            return EdgeA+EdgeB+EdgeC;
        }
        public override double CalculateArea()
        {
            return 0.5 * EdgeA * EdgeB;
        }
        
    }
}
