using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan_4
{
    class Circle : Shape
    {
        public Circle(string name ="Noname") : base(name)
        {

        }
        public Circle(string name, double radius) : base(name)
        {
            Radius = radius;
        }
        public double Radius { get; set; }
     
        public override double CalculatePerimeter()
        {
            return Radius * 2 * Math.PI;
        }
        public override double CalculateArea()
        {
            return Radius*Radius*Math.PI;
        }
       

    }
}
