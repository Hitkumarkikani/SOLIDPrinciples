using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    public abstract class Shape
    {
        public abstract double Area();
    }

    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }

    public class Square : Shape
    {
        public double Side { get; set; }

        public Square(double side)
        {
            Side = side;
        }

        public override double Area()
        {
            return Side * Side;
        }
    }

    public class AreaCalculator
    {
        public static double CalculateArea(Shape shape)
        {
            return shape.Area();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3 :- Liskov Substitution Principle :->");
            Console.WriteLine("");
            Console.WriteLine("Rectangal and Square Area :->");

            Shape rectangle = new Rectangle(5, 10);
            Console.WriteLine($"Rectangle Area: {AreaCalculator.CalculateArea(rectangle)}");

            Shape square = new Square(5);
            Console.WriteLine($"Square Area: {AreaCalculator.CalculateArea(square)}");
            Console.WriteLine("");
        }
    }
}
