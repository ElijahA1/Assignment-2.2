using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2._2
{
    abstract class Shape
    {
        public uint ShapeId { get; set; }
        public string ShapeName { get; set; }
        public string ShapeColor { get; set; }

        public virtual void calculateArea() { }
    }

    class Circle : Shape
    {
        public double Radius { get; set; }
        public override void calculateArea()
        {
            double area = Math.PI * Math.Pow(Radius, 2);
            Console.WriteLine($"The area of the circle is {area}");
        }
    }
    class Square : Shape
    {
        public double lengthOfSide { get; set; }
        public override void calculateArea()
        {
            double area = Math.Pow(lengthOfSide, 2);
            Console.WriteLine($"The area of the square is {area}");
        }
    }
}
