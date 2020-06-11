using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Shape noNameShape = new Shape();
            Console.WriteLine(noNameShape.ToString());
            Shape circleShape = new Shape("Circle");
            Console.WriteLine(circleShape.ToString());*/
            Shape[] array = new Shape[4]
            {
                new Circle("Circle",6),
                new Triangular("Triangle",3,4,5),
                new Rectangular("Rectangular",6,6),
                new RecgularHexagon("RecgularHexagon",6)

            };
            foreach ( Shape s in array)
            {
                Console.WriteLine(s.ToString());
                Console.WriteLine("Perimeter {0}", s.CalculatePerimeter());
                Console.WriteLine("Area {0}", s.CalculateArea());
                Console.WriteLine();
                
            }
            foreach (IPoint x in array)
            {
                Console.WriteLine("{0}", x.Points);
            }
           
        }
    }
}
