using Geometry.Domain;
using System;
using System.Reflection.Metadata;

namespace GeometryApp.Bad
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Geometry calculator (Soon-To-Be-Refactored)");
            Console.Write("Shape (circle/rectangle): ");
            var input = Console.ReadLine()?.Trim().ToLowerInvariant();

            // cR
            IShape? shape = input switch
            {
                "circle" => CreateCircle(),
                "retangle" => CreateRetangle(),
                _ => null
            };

            if (shape is null)
            {
                Console.WriteLine("Unknown shape.");
                return;
            }


            Console.WriteLine($"Area: {shape.Area:F2}");
            Console.WriteLine($"Perimeter: {shape.Perimeter:F2}");
        }

        private static IShape CreateCircle()
        {
            Console.Write("Radius: ");
            var r = double.Parse(Console.ReadLine() ?? "0");

            return new Circle(radius: r);
        }

        private static IShape CreateRetangle()
        {
            Console.Write("Width: ");
            var w = double.Parse(Console.ReadLine() ?? "0");
            Console.Write("Height: ");
            var h = double.Parse(Console.ReadLine() ?? "0");

            return new Rectangle(width: w, height: h);
        }
    }
}
