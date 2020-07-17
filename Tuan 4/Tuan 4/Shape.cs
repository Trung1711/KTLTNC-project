using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan_4
{
    class Shape
    { 
        public string Name { get; set; }
        public Shape(string name = "NoName")
        {
            Name = name;
        }
        public virtual double CalculatePerimeter()
        {
            throw new Exception("Not implimented");
        }
        public virtual double CalculateArea()
        {
            throw new Exception("Not implimented");
        }
        public override string ToString()
        {
            return Name;
        }
        IsRightOrder(ISortObject compare)
        {
            Shape compareShape = compare as Shape;
           
            {

            }
        }
    }
}
