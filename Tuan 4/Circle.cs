using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan_4
{
    class Circle : Shape,IPoint
    {
        public Circle(string name ="Noname") : base(name)
        {

        }
        public Circle(string name,double radius) 
        {
            Name = name;
            Radius = radius;
        }
        public double Radius { get; set; }
        public override double CalculatePerimeter()
        {
            return Radius * 2 * 3.14;
        }
        public override double CalculateArea()
        {
            return Radius*Radius*3.14;
        }
        public byte Points
        { get { return 0; } }

    }
}
